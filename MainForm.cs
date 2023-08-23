using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Tekla.Structures;
using TSD = Tekla.Structures.Drawing;
using TSM = Tekla.Structures.Model;

namespace RFIDrawingsApp
{
    public partial class DrawingsApp : Form
    {
        public DrawingsApp()
        {
            this.InitializeComponent();
        }

        private void ButtonUpdateLayout_Click_1(object sender, EventArgs e)
        {
            this.LabeUpdate("Updating layout ...", System.Drawing.Color.Firebrick);

            var dh = new TSD.DrawingHandler();
            var dwg = dh.GetActiveDrawing();
            var sizeh = dwg.Layout.SheetSize.Height;
            var sizew = dwg.Layout.SheetSize.Width;
            dwg.Layout.LoadAttributes("RFI");
            dwg.Layout.SheetSize.Height = sizeh;
            dwg.Layout.SheetSize.Width = sizew;
            dwg.Modify();

            dh.GetActiveDrawing().CommitChanges();
            this.LabeUpdate("Updating layout, complete !!!", System.Drawing.Color.Black);
        }

        private void ButtonPartColor_Click(object sender, EventArgs e)
        {
            this.LabeUpdate("Updating part colors ...", System.Drawing.Color.Firebrick);

            var dh = new TSD.DrawingHandler();
            var dwg = dh.GetActiveDrawing();
            var sheet = dwg.GetSheet();
            var doeParts = sheet.GetAllObjects(typeof(TSD.Part));

            while (doeParts.MoveNext())
            {
                var part = doeParts.Current as TSD.Part;

                part.Attributes.VisibleLines.Color = TSD.DrawingColors.Black;
                part.Attributes.HiddenLines.Color = TSD.DrawingColors.Black;

                var modelPart = new TSM.Beam { Identifier = part.ModelIdentifier };
                var rfi = string.Empty;
                modelPart.GetReportProperty("RFIcombined", ref rfi);

                if (rfi != string.Empty)
                {
                    part.Attributes.VisibleLines.Color = SetColor(rfi);
                    part.Attributes.HiddenLines.Color = SetColor(rfi);
                }

                if (!string.IsNullOrWhiteSpace(rfi))
                {
                    this.LabeUpdate("Updating colors RFI No: " + rfi + " ...", System.Drawing.Color.Firebrick);
                }

                part.Modify();
            }

            dh.GetActiveDrawing().CommitChanges();
            this.LabeUpdate("Updating part colors, complete !!!", System.Drawing.Color.Black);
        }

        private void ButtonAddPartMarks_Click(object sender, EventArgs e)
        {
            this.LabeUpdate("Adding part marks ", System.Drawing.Color.Firebrick);

            var dh = new TSD.DrawingHandler();
            var dwg = dh.GetActiveDrawing();
            var sheet = dwg.GetSheet();

            var doeParts = sheet.GetAllObjects(typeof(TSD.Part));
            var parts = new List<TSD.Part>();
            while (doeParts.MoveNext())
            {
                var part = doeParts.Current as TSD.Part;
                var modelBeam = new TSM.Beam { Identifier = part.ModelIdentifier };
                var rfi = string.Empty;
                modelBeam.GetReportProperty("RFIcombined", ref rfi);
                if (string.IsNullOrEmpty(rfi))
                {
                    continue;
                }

                var ass = modelBeam.GetAssembly();
                var modelMainBeam = ass.GetMainPart() as TSM.Beam;
                if (modelBeam.Equals(modelMainBeam))
                {
                    this.LabeUpdate("Adding part marks RFI No: " + rfi + " ...", System.Drawing.Color.Firebrick);
                    parts.Add(part);
                }
            }

            var dos = dh.GetDrawingObjectSelector();
            dos.UnselectAllObjects();
            dos.SelectObjects(new ArrayList(parts), true);

            var builder = new Tekla.Structures.MacroBuilder();
            builder.Callback("acmdCreateAppliedMarksSelected", "", "main_frame");
            builder.Run();
            MacroBuilder.WaitForMacroToRun();
            this.LabeUpdate("Adding part marks, complete !!!", System.Drawing.Color.Black);

            this.LabeUpdate("Updating colors of marks ", System.Drawing.Color.Firebrick);
            var doeMarks = sheet.GetAllObjects(typeof(TSD.Mark));
            while (doeMarks.MoveNext())
            {
                var mark = doeMarks.Current as TSD.MarkBase;

                if (mark.IsAssociativeNote)
                {
                    continue;
                }

                var relatedObjects = mark.GetRelatedObjects();
                foreach (var realatedObject in relatedObjects)
                {
                    var part = realatedObject as TSD.Part;
                    if (part == null) { continue; }

                    var modelBeam = new TSM.Beam { Identifier = part.ModelIdentifier };

                    var rfi = string.Empty;
                    modelBeam.GetReportProperty("RFIcombined", ref rfi);

                    var ass = modelBeam.GetAssembly();
                    var modelMainBeam = ass.GetMainPart() as TSM.Beam;
                    if (modelBeam.Equals(modelMainBeam))
                    {
                        if (string.IsNullOrEmpty(rfi))
                        {
                            mark.Delete();
                            mark.Modify();
                        }

                        this.LabeUpdate("Updating mark colors RFI No: " + rfi + " ...", System.Drawing.Color.Firebrick);
                        mark.Attributes.LoadAttributes("RFI");
                        mark.Attributes.Frame.Color = SetColor(rfi);
                        mark.Modify();
                    }
                }
            }

            dos.UnselectAllObjects();
            dh.GetActiveDrawing().CommitChanges();
            this.LabeUpdate("Adding part marks, complete !!!", System.Drawing.Color.Black);
        }

        private static TSD.DrawingColors SetColor(string combined)
        {
            var color = TSD.DrawingColors.Black;

            var weight = 0;
            foreach (var ch in combined) { weight += ch; }
            while (weight > 12) { weight -= 12; }

            if (weight == 1) color = TSD.DrawingColors.Red;
            if (weight == 2) color = TSD.DrawingColors.Green;
            if (weight == 3) color = TSD.DrawingColors.Blue;
            if (weight == 4) color = TSD.DrawingColors.Cyan;
            if (weight == 5) color = TSD.DrawingColors.Magenta;
            if (weight == 6) color = TSD.DrawingColors.NewLine1;
            if (weight == 7) color = TSD.DrawingColors.NewLine2;
            if (weight == 8) color = TSD.DrawingColors.NewLine3;
            if (weight == 9) color = TSD.DrawingColors.NewLine4;
            if (weight == 10) color = TSD.DrawingColors.Yellow;
            if (weight == 11) color = TSD.DrawingColors.Gray50;
            if (weight == 12) color = TSD.DrawingColors.Yellow;

            return color;
        }

        private void LabeUpdate(string text, System.Drawing.Color color)
        {
            this.Label.Text = text;
            this.Label.ForeColor = color;
            this.Label.Update();
        }

        private void DrawingsApp_Load(object sender, EventArgs e)
        {
            if (!TeklaStructures.Connect())
            {
                return;
            }
        }
    }
}
