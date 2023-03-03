namespace RFIDrawingsApp
{
    partial class DrawingsApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingsApp));
            this.ButtonUpdateLayout = new System.Windows.Forms.Button();
            this.ButtonPartColor = new System.Windows.Forms.Button();
            this.ButtonAddPartMarks = new System.Windows.Forms.Button();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonUpdateLayout
            // 
            this.ButtonUpdateLayout.Location = new System.Drawing.Point(6, 19);
            this.ButtonUpdateLayout.Name = "ButtonUpdateLayout";
            this.ButtonUpdateLayout.Size = new System.Drawing.Size(348, 41);
            this.ButtonUpdateLayout.TabIndex = 0;
            this.ButtonUpdateLayout.Text = "Update Layout";
            this.toolTip.SetToolTip(this.ButtonUpdateLayout, "Changes the layout to show the RFI’s list\r\nat the top right corner of the drawing" +
        "");
            this.ButtonUpdateLayout.UseVisualStyleBackColor = true;
            this.ButtonUpdateLayout.Click += new System.EventHandler(this.ButtonUpdateLayout_Click_1);
            // 
            // ButtonPartColor
            // 
            this.ButtonPartColor.Location = new System.Drawing.Point(9, 19);
            this.ButtonPartColor.Name = "ButtonPartColor";
            this.ButtonPartColor.Size = new System.Drawing.Size(345, 41);
            this.ButtonPartColor.TabIndex = 0;
            this.ButtonPartColor.Text = "Update Part Colors";
            this.toolTip.SetToolTip(this.ButtonPartColor, "Iterates through the parts on the drawing\r\nand updates the part colors ");
            this.ButtonPartColor.UseVisualStyleBackColor = true;
            this.ButtonPartColor.Click += new System.EventHandler(this.ButtonPartColor_Click);
            // 
            // ButtonAddPartMarks
            // 
            this.ButtonAddPartMarks.Location = new System.Drawing.Point(9, 19);
            this.ButtonAddPartMarks.Name = "ButtonAddPartMarks";
            this.ButtonAddPartMarks.Size = new System.Drawing.Size(345, 41);
            this.ButtonAddPartMarks.TabIndex = 0;
            this.ButtonAddPartMarks.Text = "Add / Update Part Marks";
            this.toolTip.SetToolTip(this.ButtonAddPartMarks, "Adds new labels, updates existing labels\r\nand removes old labels");
            this.ButtonAddPartMarks.UseVisualStyleBackColor = true;
            this.ButtonAddPartMarks.Click += new System.EventHandler(this.ButtonAddPartMarks_Click);
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.Location = new System.Drawing.Point(311, 32);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(37, 13);
            this.LabelVersion.TabIndex = 1;
            this.LabelVersion.Text = "v 2.19";
            // 
            // Label
            // 
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(7, 19);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(347, 24);
            this.Label.TabIndex = 2;
            this.Label.Text = "Please, select option ...";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LabelVersion);
            this.groupBox2.Controls.Add(this.Label);
            this.groupBox2.Location = new System.Drawing.Point(12, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 56);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ButtonUpdateLayout);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 66);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RFI Layout:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonAddPartMarks);
            this.groupBox1.Location = new System.Drawing.Point(12, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 66);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RFI Marks:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ButtonPartColor);
            this.groupBox3.Location = new System.Drawing.Point(12, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 66);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RFI Parts:";
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Tooltip:";
            // 
            // DrawingsApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 289);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DrawingsApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RFI Drawings Application";
            this.Load += new System.EventHandler(this.DrawingsApp_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonUpdateLayout;
        private System.Windows.Forms.Button ButtonPartColor;
        private System.Windows.Forms.Button ButtonAddPartMarks;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

