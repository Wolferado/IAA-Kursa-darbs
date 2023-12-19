namespace IAA_Kursa_darbs
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contrastTrackBar = new System.Windows.Forms.TrackBar();
            this.focusTrackBar = new System.Windows.Forms.TrackBar();
            this.noiseTrackBar = new System.Windows.Forms.TrackBar();
            this.mediumContrastLabel = new System.Windows.Forms.Label();
            this.lowContrastLabel = new System.Windows.Forms.Label();
            this.highContrastLabel = new System.Windows.Forms.Label();
            this.blurryFocusLabel = new System.Windows.Forms.Label();
            this.focusedFocusLabel = new System.Windows.Forms.Label();
            this.noiselessNoiseLabel = new System.Windows.Forms.Label();
            this.veryNoisyNoiseLabel = new System.Windows.Forms.Label();
            this.detailedInfoTextBox = new System.Windows.Forms.TextBox();
            this.existsVignetteLabel = new System.Windows.Forms.Label();
            this.noneVignetteLabel = new System.Windows.Forms.Label();
            this.vignetteTrackBar = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.noisyNoiseLabel = new System.Windows.Forms.Label();
            this.pictureBoxHintMsg = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.focusTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vignetteTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Peru;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 345);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(375, 160);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(393, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contrast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(393, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Focus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(393, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Noise";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contrastTrackBar
            // 
            this.contrastTrackBar.Enabled = false;
            this.contrastTrackBar.Location = new System.Drawing.Point(463, 66);
            this.contrastTrackBar.Maximum = 50;
            this.contrastTrackBar.Name = "contrastTrackBar";
            this.contrastTrackBar.Size = new System.Drawing.Size(271, 45);
            this.contrastTrackBar.TabIndex = 7;
            this.contrastTrackBar.Value = 25;
            // 
            // focusTrackBar
            // 
            this.focusTrackBar.Enabled = false;
            this.focusTrackBar.Location = new System.Drawing.Point(463, 134);
            this.focusTrackBar.Maximum = 50;
            this.focusTrackBar.Name = "focusTrackBar";
            this.focusTrackBar.Size = new System.Drawing.Size(271, 45);
            this.focusTrackBar.TabIndex = 8;
            this.focusTrackBar.Value = 25;
            // 
            // noiseTrackBar
            // 
            this.noiseTrackBar.Enabled = false;
            this.noiseTrackBar.Location = new System.Drawing.Point(463, 196);
            this.noiseTrackBar.Maximum = 50;
            this.noiseTrackBar.Name = "noiseTrackBar";
            this.noiseTrackBar.Size = new System.Drawing.Size(271, 45);
            this.noiseTrackBar.TabIndex = 9;
            this.noiseTrackBar.Value = 25;
            // 
            // mediumContrastLabel
            // 
            this.mediumContrastLabel.AutoSize = true;
            this.mediumContrastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mediumContrastLabel.Location = new System.Drawing.Point(569, 91);
            this.mediumContrastLabel.Name = "mediumContrastLabel";
            this.mediumContrastLabel.Size = new System.Drawing.Size(65, 20);
            this.mediumContrastLabel.TabIndex = 15;
            this.mediumContrastLabel.Text = "Medium";
            // 
            // lowContrastLabel
            // 
            this.lowContrastLabel.AutoSize = true;
            this.lowContrastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lowContrastLabel.Location = new System.Drawing.Point(459, 91);
            this.lowContrastLabel.Name = "lowContrastLabel";
            this.lowContrastLabel.Size = new System.Drawing.Size(38, 20);
            this.lowContrastLabel.TabIndex = 16;
            this.lowContrastLabel.Text = "Low";
            // 
            // highContrastLabel
            // 
            this.highContrastLabel.AutoSize = true;
            this.highContrastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.highContrastLabel.Location = new System.Drawing.Point(706, 91);
            this.highContrastLabel.Name = "highContrastLabel";
            this.highContrastLabel.Size = new System.Drawing.Size(42, 20);
            this.highContrastLabel.TabIndex = 17;
            this.highContrastLabel.Text = "High";
            // 
            // blurryFocusLabel
            // 
            this.blurryFocusLabel.AutoSize = true;
            this.blurryFocusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blurryFocusLabel.Location = new System.Drawing.Point(452, 159);
            this.blurryFocusLabel.Name = "blurryFocusLabel";
            this.blurryFocusLabel.Size = new System.Drawing.Size(49, 20);
            this.blurryFocusLabel.TabIndex = 18;
            this.blurryFocusLabel.Text = "Blurry";
            // 
            // focusedFocusLabel
            // 
            this.focusedFocusLabel.AutoSize = true;
            this.focusedFocusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.focusedFocusLabel.Location = new System.Drawing.Point(692, 159);
            this.focusedFocusLabel.Name = "focusedFocusLabel";
            this.focusedFocusLabel.Size = new System.Drawing.Size(71, 20);
            this.focusedFocusLabel.TabIndex = 19;
            this.focusedFocusLabel.Text = "Focused";
            // 
            // noiselessNoiseLabel
            // 
            this.noiselessNoiseLabel.AutoSize = true;
            this.noiselessNoiseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noiselessNoiseLabel.Location = new System.Drawing.Point(439, 221);
            this.noiselessNoiseLabel.Name = "noiselessNoiseLabel";
            this.noiselessNoiseLabel.Size = new System.Drawing.Size(77, 20);
            this.noiselessNoiseLabel.TabIndex = 20;
            this.noiselessNoiseLabel.Text = "Noiseless";
            // 
            // veryNoisyNoiseLabel
            // 
            this.veryNoisyNoiseLabel.AutoSize = true;
            this.veryNoisyNoiseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.veryNoisyNoiseLabel.Location = new System.Drawing.Point(688, 221);
            this.veryNoisyNoiseLabel.Name = "veryNoisyNoiseLabel";
            this.veryNoisyNoiseLabel.Size = new System.Drawing.Size(83, 20);
            this.veryNoisyNoiseLabel.TabIndex = 21;
            this.veryNoisyNoiseLabel.Text = "Very Noisy";
            // 
            // detailedInfoTextBox
            // 
            this.detailedInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detailedInfoTextBox.Location = new System.Drawing.Point(398, 345);
            this.detailedInfoTextBox.Multiline = true;
            this.detailedInfoTextBox.Name = "detailedInfoTextBox";
            this.detailedInfoTextBox.ReadOnly = true;
            this.detailedInfoTextBox.Size = new System.Drawing.Size(370, 160);
            this.detailedInfoTextBox.TabIndex = 24;
            this.detailedInfoTextBox.Text = "Detailed information:";
            // 
            // existsVignetteLabel
            // 
            this.existsVignetteLabel.AutoSize = true;
            this.existsVignetteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.existsVignetteLabel.Location = new System.Drawing.Point(699, 305);
            this.existsVignetteLabel.Name = "existsVignetteLabel";
            this.existsVignetteLabel.Size = new System.Drawing.Size(51, 20);
            this.existsVignetteLabel.TabIndex = 29;
            this.existsVignetteLabel.Text = "Exists";
            // 
            // noneVignetteLabel
            // 
            this.noneVignetteLabel.AutoSize = true;
            this.noneVignetteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noneVignetteLabel.Location = new System.Drawing.Point(452, 305);
            this.noneVignetteLabel.Name = "noneVignetteLabel";
            this.noneVignetteLabel.Size = new System.Drawing.Size(47, 20);
            this.noneVignetteLabel.TabIndex = 28;
            this.noneVignetteLabel.Text = "None";
            // 
            // vignetteTrackBar
            // 
            this.vignetteTrackBar.Enabled = false;
            this.vignetteTrackBar.Location = new System.Drawing.Point(461, 280);
            this.vignetteTrackBar.Maximum = 50;
            this.vignetteTrackBar.Name = "vignetteTrackBar";
            this.vignetteTrackBar.Size = new System.Drawing.Size(271, 45);
            this.vignetteTrackBar.TabIndex = 27;
            this.vignetteTrackBar.Value = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(393, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "Vignette";
            // 
            // noisyNoiseLabel
            // 
            this.noisyNoiseLabel.AutoSize = true;
            this.noisyNoiseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noisyNoiseLabel.Location = new System.Drawing.Point(573, 221);
            this.noisyNoiseLabel.Name = "noisyNoiseLabel";
            this.noisyNoiseLabel.Size = new System.Drawing.Size(47, 20);
            this.noisyNoiseLabel.TabIndex = 30;
            this.noisyNoiseLabel.Text = "Noisy";
            // 
            // pictureBoxHintMsg
            // 
            this.pictureBoxHintMsg.AutoSize = true;
            this.pictureBoxHintMsg.BackColor = System.Drawing.Color.Black;
            this.pictureBoxHintMsg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxHintMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pictureBoxHintMsg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxHintMsg.Location = new System.Drawing.Point(93, 134);
            this.pictureBoxHintMsg.Name = "pictureBoxHintMsg";
            this.pictureBoxHintMsg.Size = new System.Drawing.Size(188, 17);
            this.pictureBoxHintMsg.TabIndex = 31;
            this.pictureBoxHintMsg.Text = "Click here to add an Image...";
            this.pictureBoxHintMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pictureBoxHintMsg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.pictureBoxHintMsg);
            this.Controls.Add(this.noisyNoiseLabel);
            this.Controls.Add(this.existsVignetteLabel);
            this.Controls.Add(this.noneVignetteLabel);
            this.Controls.Add(this.vignetteTrackBar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.detailedInfoTextBox);
            this.Controls.Add(this.veryNoisyNoiseLabel);
            this.Controls.Add(this.noiselessNoiseLabel);
            this.Controls.Add(this.focusedFocusLabel);
            this.Controls.Add(this.blurryFocusLabel);
            this.Controls.Add(this.highContrastLabel);
            this.Controls.Add(this.lowContrastLabel);
            this.Controls.Add(this.mediumContrastLabel);
            this.Controls.Add(this.noiseTrackBar);
            this.Controls.Add(this.focusTrackBar);
            this.Controls.Add(this.contrastTrackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "IAA - Attelu kvalitativu problemu noteiksana";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.focusTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vignetteTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TrackBar contrastTrackBar;
        private System.Windows.Forms.TrackBar focusTrackBar;
        private System.Windows.Forms.TrackBar noiseTrackBar;
        private System.Windows.Forms.Label mediumContrastLabel;
        private System.Windows.Forms.Label lowContrastLabel;
        private System.Windows.Forms.Label highContrastLabel;
        private System.Windows.Forms.Label blurryFocusLabel;
        private System.Windows.Forms.Label focusedFocusLabel;
        private System.Windows.Forms.Label noiselessNoiseLabel;
        private System.Windows.Forms.Label veryNoisyNoiseLabel;
        private System.Windows.Forms.TextBox detailedInfoTextBox;
        private System.Windows.Forms.Label existsVignetteLabel;
        private System.Windows.Forms.Label noneVignetteLabel;
        private System.Windows.Forms.TrackBar vignetteTrackBar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label noisyNoiseLabel;
        private System.Windows.Forms.Label pictureBoxHintMsg;
    }
}