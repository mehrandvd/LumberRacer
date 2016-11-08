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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxCamera = new System.Windows.Forms.GroupBox();
            this.panelCameraStatus = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVertical)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxCamera.SuspendLayout();
            this.panelCameraStatus.SuspendLayout();
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
            this.pictureMonitor.BackColor = System.Drawing.SystemColors.Control;
            this.pictureMonitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureMonitor.Location = new System.Drawing.Point(8, 18);
            this.pictureMonitor.Name = "pictureMonitor";
            this.pictureMonitor.Size = new System.Drawing.Size(229, 335);
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
            this.trackBarHorizontal.Location = new System.Drawing.Point(6, 386);
            this.trackBarHorizontal.Maximum = 1000;
            this.trackBarHorizontal.Name = "trackBarHorizontal";
            this.trackBarHorizontal.Size = new System.Drawing.Size(245, 45);
            this.trackBarHorizontal.SmallChange = 10;
            this.trackBarHorizontal.TabIndex = 9;
            this.trackBarHorizontal.Value = 400;
            // 
            // trackBarVertical
            // 
            this.trackBarVertical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarVertical.LargeChange = 50;
            this.trackBarVertical.Location = new System.Drawing.Point(257, 31);
            this.trackBarVertical.Maximum = 1000;
            this.trackBarVertical.Name = "trackBarVertical";
            this.trackBarVertical.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVertical.Size = new System.Drawing.Size(45, 355);
            this.trackBarVertical.SmallChange = 10;
            this.trackBarVertical.TabIndex = 10;
            this.trackBarVertical.Value = 600;
            // 
            // flowLayoutPanelAlgorithmConfig
            // 
            this.flowLayoutPanelAlgorithmConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelAlgorithmConfig.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelAlgorithmConfig.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanelAlgorithmConfig.Name = "flowLayoutPanelAlgorithmConfig";
            this.flowLayoutPanelAlgorithmConfig.Size = new System.Drawing.Size(131, 361);
            this.flowLayoutPanelAlgorithmConfig.TabIndex = 14;
            // 
            // richTextBoxHelp
            // 
            this.richTextBoxHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.flowLayoutPanelAlgorithmConfig);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithm Settings";
            // 
            // groupBoxCamera
            // 
            this.groupBoxCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCamera.Controls.Add(this.panelCameraStatus);
            this.groupBoxCamera.Controls.Add(this.trackBarHorizontal);
            this.groupBoxCamera.Controls.Add(this.trackBarVertical);
            this.groupBoxCamera.Location = new System.Drawing.Point(161, 12);
            this.groupBoxCamera.Name = "groupBoxCamera";
            this.groupBoxCamera.Size = new System.Drawing.Size(308, 437);
            this.groupBoxCamera.TabIndex = 16;
            this.groupBoxCamera.TabStop = false;
            this.groupBoxCamera.Text = "Camera";
            // 
            // panelCameraStatus
            // 
            this.panelCameraStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCameraStatus.BackColor = System.Drawing.Color.Red;
            this.panelCameraStatus.Controls.Add(this.pictureMonitor);
            this.panelCameraStatus.Location = new System.Drawing.Point(6, 19);
            this.panelCameraStatus.Name = "panelCameraStatus";
            this.panelCameraStatus.Padding = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.panelCameraStatus.Size = new System.Drawing.Size(245, 361);
            this.panelCameraStatus.TabIndex = 11;
            // 
            // LumberjackRacerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.groupBoxCamera);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBoxHelp);
            this.Controls.Add(this.btnStartEye);
            this.Controls.Add(this.listLog);
            this.Name = "LumberjackRacerForm";
            this.Text = "Telegram Lumberjack Racer - by @mehrandvd";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.LumberjackRacerForm_Activated);
            this.Deactivate += new System.EventHandler(this.LumberjackRacerForm_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVertical)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxCamera.ResumeLayout(false);
            this.groupBoxCamera.PerformLayout();
            this.panelCameraStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.PictureBox pictureMonitor;
        private System.Windows.Forms.Button btnStartEye;
        private System.Windows.Forms.TrackBar trackBarHorizontal;
        private System.Windows.Forms.TrackBar trackBarVertical;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlgorithmConfig;
        private System.Windows.Forms.RichTextBox richTextBoxHelp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxCamera;
        private System.Windows.Forms.Panel panelCameraStatus;
    }
}

