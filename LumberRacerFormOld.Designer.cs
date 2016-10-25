namespace LumberRacer
{
    partial class LumberRacerFormOld
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
            this.listLog = new System.Windows.Forms.ListBox();
            this.pictureBoxEye = new System.Windows.Forms.PictureBox();
            this.btnStartEye = new System.Windows.Forms.Button();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.panelSelectedColor = new System.Windows.Forms.Panel();
            this.numericUpDownBeamSize = new System.Windows.Forms.NumericUpDown();
            this.labelBeamSize = new System.Windows.Forms.Label();
            this.trackBarHorizontal = new System.Windows.Forms.TrackBar();
            this.trackBarVertical = new System.Windows.Forms.TrackBar();
            this.numericUpDownRefreshRate = new System.Windows.Forms.NumericUpDown();
            this.labelRefreshRate = new System.Windows.Forms.Label();
            this.numericUpDownRequiredScore = new System.Windows.Forms.NumericUpDown();
            this.labelRequiredScore = new System.Windows.Forms.Label();
            this.pictureBoxLost = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownColorPrecision = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGridSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeamSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefreshRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRequiredScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColorPrecision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGridSize)).BeginInit();
            this.SuspendLayout();
            // 
            // listLog
            // 
            this.listLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listLog.FormattingEnabled = true;
            this.listLog.Location = new System.Drawing.Point(1013, 12);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(157, 654);
            this.listLog.TabIndex = 0;
            // 
            // pictureBoxEye
            // 
            this.pictureBoxEye.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxEye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEye.Location = new System.Drawing.Point(150, 12);
            this.pictureBoxEye.Name = "pictureBoxEye";
            this.pictureBoxEye.Size = new System.Drawing.Size(321, 600);
            this.pictureBoxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEye.TabIndex = 1;
            this.pictureBoxEye.TabStop = false;
            this.pictureBoxEye.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxEye_MouseClick);
            // 
            // btnStartEye
            // 
            this.btnStartEye.Location = new System.Drawing.Point(12, 209);
            this.btnStartEye.Name = "btnStartEye";
            this.btnStartEye.Size = new System.Drawing.Size(132, 35);
            this.btnStartEye.TabIndex = 2;
            this.btnStartEye.Text = "Look for game";
            this.btnStartEye.UseVisualStyleBackColor = true;
            this.btnStartEye.Click += new System.EventHandler(this.btnStartEye_Click);
            // 
            // textBoxR
            // 
            this.textBoxR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxR.Location = new System.Drawing.Point(12, 540);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 20);
            this.textBoxR.TabIndex = 3;
            // 
            // textBoxG
            // 
            this.textBoxG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxG.Location = new System.Drawing.Point(11, 566);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(100, 20);
            this.textBoxG.TabIndex = 3;
            // 
            // textBoxB
            // 
            this.textBoxB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxB.Location = new System.Drawing.Point(11, 592);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 3;
            // 
            // panelSelectedColor
            // 
            this.panelSelectedColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSelectedColor.Location = new System.Drawing.Point(12, 465);
            this.panelSelectedColor.Name = "panelSelectedColor";
            this.panelSelectedColor.Size = new System.Drawing.Size(78, 69);
            this.panelSelectedColor.TabIndex = 4;
            // 
            // numericUpDownBeamSize
            // 
            this.numericUpDownBeamSize.Location = new System.Drawing.Point(12, 65);
            this.numericUpDownBeamSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBeamSize.Name = "numericUpDownBeamSize";
            this.numericUpDownBeamSize.Size = new System.Drawing.Size(132, 20);
            this.numericUpDownBeamSize.TabIndex = 7;
            this.numericUpDownBeamSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelBeamSize
            // 
            this.labelBeamSize.AutoSize = true;
            this.labelBeamSize.Location = new System.Drawing.Point(9, 49);
            this.labelBeamSize.Name = "labelBeamSize";
            this.labelBeamSize.Size = new System.Drawing.Size(78, 13);
            this.labelBeamSize.TabIndex = 8;
            this.labelBeamSize.Text = "Beam size (px):";
            // 
            // trackBarHorizontal
            // 
            this.trackBarHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarHorizontal.LargeChange = 50;
            this.trackBarHorizontal.Location = new System.Drawing.Point(150, 621);
            this.trackBarHorizontal.Maximum = 1000;
            this.trackBarHorizontal.Name = "trackBarHorizontal";
            this.trackBarHorizontal.Size = new System.Drawing.Size(321, 45);
            this.trackBarHorizontal.SmallChange = 10;
            this.trackBarHorizontal.TabIndex = 9;
            this.trackBarHorizontal.Value = 400;
            // 
            // trackBarVertical
            // 
            this.trackBarVertical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarVertical.LargeChange = 50;
            this.trackBarVertical.Location = new System.Drawing.Point(477, 12);
            this.trackBarVertical.Maximum = 1000;
            this.trackBarVertical.Name = "trackBarVertical";
            this.trackBarVertical.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVertical.Size = new System.Drawing.Size(45, 600);
            this.trackBarVertical.SmallChange = 10;
            this.trackBarVertical.TabIndex = 10;
            this.trackBarVertical.Value = 600;
            // 
            // numericUpDownRefreshRate
            // 
            this.numericUpDownRefreshRate.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRefreshRate.Location = new System.Drawing.Point(12, 144);
            this.numericUpDownRefreshRate.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownRefreshRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRefreshRate.Name = "numericUpDownRefreshRate";
            this.numericUpDownRefreshRate.Size = new System.Drawing.Size(132, 20);
            this.numericUpDownRefreshRate.TabIndex = 7;
            this.numericUpDownRefreshRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelRefreshRate
            // 
            this.labelRefreshRate.AutoSize = true;
            this.labelRefreshRate.Location = new System.Drawing.Point(9, 128);
            this.labelRefreshRate.Name = "labelRefreshRate";
            this.labelRefreshRate.Size = new System.Drawing.Size(95, 13);
            this.labelRefreshRate.TabIndex = 8;
            this.labelRefreshRate.Text = "Refresh Rate (ms):";
            // 
            // numericUpDownRequiredScore
            // 
            this.numericUpDownRequiredScore.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownRequiredScore.Location = new System.Drawing.Point(12, 183);
            this.numericUpDownRequiredScore.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDownRequiredScore.Name = "numericUpDownRequiredScore";
            this.numericUpDownRequiredScore.Size = new System.Drawing.Size(132, 20);
            this.numericUpDownRequiredScore.TabIndex = 7;
            this.numericUpDownRequiredScore.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelRequiredScore
            // 
            this.labelRequiredScore.AutoSize = true;
            this.labelRequiredScore.Location = new System.Drawing.Point(9, 167);
            this.labelRequiredScore.Name = "labelRequiredScore";
            this.labelRequiredScore.Size = new System.Drawing.Size(84, 13);
            this.labelRequiredScore.TabIndex = 8;
            this.labelRequiredScore.Text = "Required Score:";
            // 
            // pictureBoxLost
            // 
            this.pictureBoxLost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLost.Location = new System.Drawing.Point(543, 12);
            this.pictureBoxLost.Name = "pictureBoxLost";
            this.pictureBoxLost.Size = new System.Drawing.Size(464, 654);
            this.pictureBoxLost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLost.TabIndex = 11;
            this.pictureBoxLost.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Color precision:";
            // 
            // numericUpDownColorPrecision
            // 
            this.numericUpDownColorPrecision.Location = new System.Drawing.Point(12, 104);
            this.numericUpDownColorPrecision.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownColorPrecision.Name = "numericUpDownColorPrecision";
            this.numericUpDownColorPrecision.Size = new System.Drawing.Size(132, 20);
            this.numericUpDownColorPrecision.TabIndex = 12;
            this.numericUpDownColorPrecision.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownGridSize
            // 
            this.numericUpDownGridSize.Location = new System.Drawing.Point(12, 26);
            this.numericUpDownGridSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGridSize.Name = "numericUpDownGridSize";
            this.numericUpDownGridSize.Size = new System.Drawing.Size(132, 20);
            this.numericUpDownGridSize.TabIndex = 7;
            this.numericUpDownGridSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Griding size (px):";
            // 
            // LumberRacerFormOld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 693);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownColorPrecision);
            this.Controls.Add(this.pictureBoxLost);
            this.Controls.Add(this.trackBarVertical);
            this.Controls.Add(this.trackBarHorizontal);
            this.Controls.Add(this.labelRequiredScore);
            this.Controls.Add(this.numericUpDownRequiredScore);
            this.Controls.Add(this.labelRefreshRate);
            this.Controls.Add(this.numericUpDownRefreshRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBeamSize);
            this.Controls.Add(this.numericUpDownGridSize);
            this.Controls.Add(this.numericUpDownBeamSize);
            this.Controls.Add(this.panelSelectedColor);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.btnStartEye);
            this.Controls.Add(this.pictureBoxEye);
            this.Controls.Add(this.listLog);
            this.Name = "LumberRacerFormOld";
            this.Text = "Lumber Racer - By Mehran DVD";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.LumberRacerForm_Activated);
            this.Deactivate += new System.EventHandler(this.LumberRacerForm_Deactivate);
            this.Load += new System.EventHandler(this.LumberRacerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeamSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefreshRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRequiredScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColorPrecision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGridSize)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDownBeamSize;
        private System.Windows.Forms.Label labelBeamSize;
        private System.Windows.Forms.TrackBar trackBarHorizontal;
        private System.Windows.Forms.TrackBar trackBarVertical;
        private System.Windows.Forms.NumericUpDown numericUpDownRefreshRate;
        private System.Windows.Forms.Label labelRefreshRate;
        private System.Windows.Forms.NumericUpDown numericUpDownRequiredScore;
        private System.Windows.Forms.Label labelRequiredScore;
        private System.Windows.Forms.PictureBox pictureBoxLost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownColorPrecision;
        private System.Windows.Forms.NumericUpDown numericUpDownGridSize;
        private System.Windows.Forms.Label label2;
    }
}

