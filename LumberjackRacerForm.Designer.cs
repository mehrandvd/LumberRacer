namespace LumberRacer
{
    partial class LumberjackRacerForm
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
            this.pictureMonitor = new System.Windows.Forms.PictureBox();
            this.btnStartEye = new System.Windows.Forms.Button();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.panelSelectedColor = new System.Windows.Forms.Panel();
            this.trackBarHorizontal = new System.Windows.Forms.TrackBar();
            this.trackBarVertical = new System.Windows.Forms.TrackBar();
            this.pictureBoxLost = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelAlgorithmConfig = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLost)).BeginInit();
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
            // pictureMonitor
            // 
            this.pictureMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMonitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureMonitor.Location = new System.Drawing.Point(150, 12);
            this.pictureMonitor.Name = "pictureMonitor";
            this.pictureMonitor.Size = new System.Drawing.Size(321, 600);
            this.pictureMonitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMonitor.TabIndex = 1;
            this.pictureMonitor.TabStop = false;
            // 
            // btnStartEye
            // 
            this.btnStartEye.Location = new System.Drawing.Point(11, 621);
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
            // flowLayoutPanelAlgorithmConfig
            // 
            this.flowLayoutPanelAlgorithmConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelAlgorithmConfig.AutoSize = true;
            this.flowLayoutPanelAlgorithmConfig.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelAlgorithmConfig.Location = new System.Drawing.Point(11, 12);
            this.flowLayoutPanelAlgorithmConfig.Name = "flowLayoutPanelAlgorithmConfig";
            this.flowLayoutPanelAlgorithmConfig.Size = new System.Drawing.Size(133, 188);
            this.flowLayoutPanelAlgorithmConfig.TabIndex = 14;
            // 
            // LumberjackRacerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 693);
            this.Controls.Add(this.flowLayoutPanelAlgorithmConfig);
            this.Controls.Add(this.pictureBoxLost);
            this.Controls.Add(this.trackBarVertical);
            this.Controls.Add(this.trackBarHorizontal);
            this.Controls.Add(this.panelSelectedColor);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.btnStartEye);
            this.Controls.Add(this.pictureMonitor);
            this.Controls.Add(this.listLog);
            this.Name = "LumberjackRacerForm";
            this.Text = "Lumber Racer - By Mehran DVD";
            this.Activated += new System.EventHandler(this.LumberjackRacerForm_Activated);
            this.Deactivate += new System.EventHandler(this.LumberjackRacerForm_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.PictureBox pictureMonitor;
        private System.Windows.Forms.Button btnStartEye;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Panel panelSelectedColor;
        private System.Windows.Forms.TrackBar trackBarHorizontal;
        private System.Windows.Forms.TrackBar trackBarVertical;
        private System.Windows.Forms.PictureBox pictureBoxLost;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlgorithmConfig;
    }
}

