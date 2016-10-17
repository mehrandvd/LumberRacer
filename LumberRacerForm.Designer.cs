namespace LumberRacer
{
    partial class LumberRacerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LumberRacerForm));
            this.listLog = new System.Windows.Forms.ListBox();
            this.pictureBoxEye = new System.Windows.Forms.PictureBox();
            this.btnStartEye = new System.Windows.Forms.Button();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.panelSelectedColor = new System.Windows.Forms.Panel();
            this.trackBarBeamSize = new System.Windows.Forms.TrackBar();
            this.panelHead = new System.Windows.Forms.Panel();
            this.panelTree = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBeamSize)).BeginInit();
            this.SuspendLayout();
            // 
            // listLog
            // 
            this.listLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listLog.FormattingEnabled = true;
            this.listLog.Location = new System.Drawing.Point(641, 12);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(311, 680);
            this.listLog.TabIndex = 0;
            // 
            // pictureBoxEye
            // 
            this.pictureBoxEye.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxEye.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEye.Image")));
            this.pictureBoxEye.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxEye.Name = "pictureBoxEye";
            this.pictureBoxEye.Size = new System.Drawing.Size(544, 466);
            this.pictureBoxEye.TabIndex = 1;
            this.pictureBoxEye.TabStop = false;
            this.pictureBoxEye.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxEye_MouseClick);
            // 
            // btnStartEye
            // 
            this.btnStartEye.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartEye.Location = new System.Drawing.Point(13, 655);
            this.btnStartEye.Name = "btnStartEye";
            this.btnStartEye.Size = new System.Drawing.Size(110, 35);
            this.btnStartEye.TabIndex = 2;
            this.btnStartEye.Text = "Start Eye";
            this.btnStartEye.UseVisualStyleBackColor = true;
            this.btnStartEye.Click += new System.EventHandler(this.btnStartEye_Click);
            // 
            // textBoxR
            // 
            this.textBoxR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxR.Location = new System.Drawing.Point(13, 494);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 20);
            this.textBoxR.TabIndex = 3;
            // 
            // textBoxG
            // 
            this.textBoxG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxG.Location = new System.Drawing.Point(12, 520);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(100, 20);
            this.textBoxG.TabIndex = 3;
            // 
            // textBoxB
            // 
            this.textBoxB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxB.Location = new System.Drawing.Point(12, 546);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 3;
            // 
            // panelSelectedColor
            // 
            this.panelSelectedColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSelectedColor.Location = new System.Drawing.Point(119, 496);
            this.panelSelectedColor.Name = "panelSelectedColor";
            this.panelSelectedColor.Size = new System.Drawing.Size(78, 69);
            this.panelSelectedColor.TabIndex = 4;
            // 
            // trackBarBeamSize
            // 
            this.trackBarBeamSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBarBeamSize.LargeChange = 10;
            this.trackBarBeamSize.Location = new System.Drawing.Point(203, 496);
            this.trackBarBeamSize.Maximum = 50;
            this.trackBarBeamSize.Name = "trackBarBeamSize";
            this.trackBarBeamSize.Size = new System.Drawing.Size(353, 45);
            this.trackBarBeamSize.SmallChange = 10;
            this.trackBarBeamSize.TabIndex = 5;
            this.trackBarBeamSize.Value = 5;
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.Maroon;
            this.panelHead.Location = new System.Drawing.Point(591, 342);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(20, 20);
            this.panelHead.TabIndex = 6;
            // 
            // panelTree
            // 
            this.panelTree.BackColor = System.Drawing.Color.Black;
            this.panelTree.Location = new System.Drawing.Point(591, 382);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(20, 20);
            this.panelTree.TabIndex = 6;
            // 
            // LumberRacerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 702);
            this.Controls.Add(this.panelTree);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.trackBarBeamSize);
            this.Controls.Add(this.panelSelectedColor);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.btnStartEye);
            this.Controls.Add(this.pictureBoxEye);
            this.Controls.Add(this.listLog);
            this.Name = "LumberRacerForm";
            this.Text = "Lumber Racer - By Mehran DVD";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBeamSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.PictureBox pictureBoxEye;
        private System.Windows.Forms.Button btnStartEye;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Panel panelSelectedColor;
        private System.Windows.Forms.TrackBar trackBarBeamSize;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Panel panelTree;
    }
}

