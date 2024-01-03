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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.detailedInfoTextBox = new System.Windows.Forms.TextBox();
            this.pictureBoxHintMsg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.contrastSlider = new System.Windows.Forms.PictureBox();
            this.focusSlider = new System.Windows.Forms.PictureBox();
            this.noiseSlider = new System.Windows.Forms.PictureBox();
            this.vignetteSlider = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.focusSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vignetteSlider)).BeginInit();
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(393, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(379, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(393, 110);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(379, 70);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 35;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(393, 186);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(379, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(393, 262);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(379, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // contrastSlider
            // 
            this.contrastSlider.BackColor = System.Drawing.Color.Black;
            this.contrastSlider.Image = ((System.Drawing.Image)(resources.GetObject("contrastSlider.Image")));
            this.contrastSlider.Location = new System.Drawing.Point(417, 58);
            this.contrastSlider.Name = "contrastSlider";
            this.contrastSlider.Size = new System.Drawing.Size(12, 27);
            this.contrastSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contrastSlider.TabIndex = 36;
            this.contrastSlider.TabStop = false;
            // 
            // focusSlider
            // 
            this.focusSlider.BackColor = System.Drawing.Color.Black;
            this.focusSlider.Image = ((System.Drawing.Image)(resources.GetObject("focusSlider.Image")));
            this.focusSlider.Location = new System.Drawing.Point(417, 134);
            this.focusSlider.Name = "focusSlider";
            this.focusSlider.Size = new System.Drawing.Size(12, 27);
            this.focusSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.focusSlider.TabIndex = 37;
            this.focusSlider.TabStop = false;
            // 
            // noiseSlider
            // 
            this.noiseSlider.BackColor = System.Drawing.Color.Black;
            this.noiseSlider.Image = ((System.Drawing.Image)(resources.GetObject("noiseSlider.Image")));
            this.noiseSlider.Location = new System.Drawing.Point(417, 210);
            this.noiseSlider.Name = "noiseSlider";
            this.noiseSlider.Size = new System.Drawing.Size(12, 27);
            this.noiseSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noiseSlider.TabIndex = 38;
            this.noiseSlider.TabStop = false;
            // 
            // vignetteSlider
            // 
            this.vignetteSlider.BackColor = System.Drawing.Color.Black;
            this.vignetteSlider.Image = ((System.Drawing.Image)(resources.GetObject("vignetteSlider.Image")));
            this.vignetteSlider.Location = new System.Drawing.Point(417, 286);
            this.vignetteSlider.Name = "vignetteSlider";
            this.vignetteSlider.Size = new System.Drawing.Size(12, 27);
            this.vignetteSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vignetteSlider.TabIndex = 39;
            this.vignetteSlider.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = global::IAA_Kursa_darbs.Properties.Resources.SandBackground;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.vignetteSlider);
            this.Controls.Add(this.noiseSlider);
            this.Controls.Add(this.focusSlider);
            this.Controls.Add(this.contrastSlider);
            this.Controls.Add(this.pictureBoxHintMsg);
            this.Controls.Add(this.detailedInfoTextBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "IAA - Attelu kvalitativu problemu noteiksana";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.focusSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vignetteSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox detailedInfoTextBox;
        private System.Windows.Forms.Label pictureBoxHintMsg;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox contrastSlider;
        private System.Windows.Forms.PictureBox focusSlider;
        private System.Windows.Forms.PictureBox noiseSlider;
        private System.Windows.Forms.PictureBox vignetteSlider;
    }
}