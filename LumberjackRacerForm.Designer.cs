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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LumberjackRacerForm));
            this.listLog = new System.Windows.Forms.ListBox();
            this.pictureMonitor = new System.Windows.Forms.PictureBox();
            this.btnStartEye = new System.Windows.Forms.Button();
            this.trackBarHorizontal = new System.Windows.Forms.TrackBar();
            this.trackBarVertical = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanelAlgorithmConfig = new System.Windows.Forms.FlowLayoutPanel();
            this.richTextBoxHelp = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVertical)).BeginInit();
            this.SuspendLayout();
            // 
            // listLog
            // 
            this.listLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listLog.FormattingEnabled = true;
            this.listLog.Location = new System.Drawing.Point(475, 302);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(247, 147);
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
            this.pictureMonitor.Size = new System.Drawing.Size(268, 386);
            this.pictureMonitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMonitor.TabIndex = 1;
            this.pictureMonitor.TabStop = false;
            // 
            // btnStartEye
            // 
            this.btnStartEye.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartEye.Location = new System.Drawing.Point(11, 414);
            this.btnStartEye.Name = "btnStartEye";
            this.btnStartEye.Size = new System.Drawing.Size(132, 35);
            this.btnStartEye.TabIndex = 2;
            this.btnStartEye.Text = "Start Eye";
            this.btnStartEye.UseVisualStyleBackColor = true;
            this.btnStartEye.Click += new System.EventHandler(this.btnStartEye_Click);
            // 
            // trackBarHorizontal
            // 
            this.trackBarHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarHorizontal.LargeChange = 50;
            this.trackBarHorizontal.Location = new System.Drawing.Point(150, 404);
            this.trackBarHorizontal.Maximum = 1000;
            this.trackBarHorizontal.Name = "trackBarHorizontal";
            this.trackBarHorizontal.Size = new System.Drawing.Size(268, 45);
            this.trackBarHorizontal.SmallChange = 10;
            this.trackBarHorizontal.TabIndex = 9;
            this.trackBarHorizontal.Value = 400;
            // 
            // trackBarVertical
            // 
            this.trackBarVertical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarVertical.LargeChange = 50;
            this.trackBarVertical.Location = new System.Drawing.Point(424, 12);
            this.trackBarVertical.Maximum = 1000;
            this.trackBarVertical.Name = "trackBarVertical";
            this.trackBarVertical.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVertical.Size = new System.Drawing.Size(45, 386);
            this.trackBarVertical.SmallChange = 10;
            this.trackBarVertical.TabIndex = 10;
            this.trackBarVertical.Value = 600;
            // 
            // flowLayoutPanelAlgorithmConfig
            // 
            this.flowLayoutPanelAlgorithmConfig.AutoSize = true;
            this.flowLayoutPanelAlgorithmConfig.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelAlgorithmConfig.Location = new System.Drawing.Point(11, 12);
            this.flowLayoutPanelAlgorithmConfig.Name = "flowLayoutPanelAlgorithmConfig";
            this.flowLayoutPanelAlgorithmConfig.Size = new System.Drawing.Size(133, 386);
            this.flowLayoutPanelAlgorithmConfig.TabIndex = 14;
            // 
            // richTextBoxHelp
            // 
            this.richTextBoxHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxHelp.BackColor = System.Drawing.Color.LightYellow;
            this.richTextBoxHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxHelp.Location = new System.Drawing.Point(475, 12);
            this.richTextBoxHelp.Name = "richTextBoxHelp";
            this.richTextBoxHelp.ReadOnly = true;
            this.richTextBoxHelp.Size = new System.Drawing.Size(247, 284);
            this.richTextBoxHelp.TabIndex = 15;
            this.richTextBoxHelp.Text = resources.GetString("richTextBoxHelp.Text");
            this.richTextBoxHelp.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxHelp_LinkClicked);
            // 
            // LumberjackRacerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.richTextBoxHelp);
            this.Controls.Add(this.flowLayoutPanelAlgorithmConfig);
            this.Controls.Add(this.trackBarVertical);
            this.Controls.Add(this.trackBarHorizontal);
            this.Controls.Add(this.btnStartEye);
            this.Controls.Add(this.pictureMonitor);
            this.Controls.Add(this.listLog);
            this.Name = "LumberjackRacerForm";
            this.Text = "Lumber Racer - By Mehran DVD";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.LumberjackRacerForm_Activated);
            this.Deactivate += new System.EventHandler(this.LumberjackRacerForm_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVertical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.PictureBox pictureMonitor;
        private System.Windows.Forms.Button btnStartEye;
        private System.Windows.Forms.TrackBar trackBarHorizontal;
        private System.Windows.Forms.TrackBar trackBarVertical;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlgorithmConfig;
        private System.Windows.Forms.RichTextBox richTextBoxHelp;
    }
}

