namespace screendrawer_v2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.canvas = new System.Windows.Forms.Panel();
            this.sizeTrackBar = new System.Windows.Forms.TrackBar();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.penButton = new System.Windows.Forms.Button();
            this.eraserButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.penButton2 = new System.Windows.Forms.Button();
            this.penButton1 = new System.Windows.Forms.Button();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.colorPreview = new System.Windows.Forms.Panel();
            this.sizePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).BeginInit();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.colorPanel.SuspendLayout();
            this.sizePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.Transparent;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1510, 735);
            this.canvas.TabIndex = 0;
            // 
            // sizeTrackBar
            // 
            this.sizeTrackBar.LargeChange = 10;
            this.sizeTrackBar.Location = new System.Drawing.Point(3, 34);
            this.sizeTrackBar.Maximum = 100;
            this.sizeTrackBar.Minimum = 1;
            this.sizeTrackBar.Name = "sizeTrackBar";
            this.sizeTrackBar.Size = new System.Drawing.Size(227, 56);
            this.sizeTrackBar.TabIndex = 1;
            this.sizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sizeTrackBar.Value = 1;
            this.sizeTrackBar.Scroll += new System.EventHandler(this.sizeTrackBar_Scroll);
            // 
            // controlsPanel
            // 
            this.controlsPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.controlsPanel.Controls.Add(this.penButton);
            this.controlsPanel.Controls.Add(this.eraserButton);
            this.controlsPanel.Controls.Add(this.clearButton);
            this.controlsPanel.Controls.Add(this.closeButton);
            this.controlsPanel.Controls.Add(this.maximizeButton);
            this.controlsPanel.Controls.Add(this.minimizeButton);
            this.controlsPanel.Controls.Add(this.penButton2);
            this.controlsPanel.Controls.Add(this.penButton1);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlsPanel.Location = new System.Drawing.Point(1047, 0);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(463, 72);
            this.controlsPanel.TabIndex = 2;
            // 
            // penButton
            // 
            this.penButton.Image = ((System.Drawing.Image)(resources.GetObject("penButton.Image")));
            this.penButton.Location = new System.Drawing.Point(123, 11);
            this.penButton.Name = "penButton";
            this.penButton.Size = new System.Drawing.Size(50, 50);
            this.penButton.TabIndex = 7;
            this.penButton.UseVisualStyleBackColor = true;
            this.penButton.Click += new System.EventHandler(this.penButton_Click);
            // 
            // eraserButton
            // 
            this.eraserButton.Image = ((System.Drawing.Image)(resources.GetObject("eraserButton.Image")));
            this.eraserButton.Location = new System.Drawing.Point(179, 11);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Size = new System.Drawing.Size(50, 50);
            this.eraserButton.TabIndex = 6;
            this.eraserButton.UseVisualStyleBackColor = true;
            this.eraserButton.Click += new System.EventHandler(this.eraserButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
            this.clearButton.Location = new System.Drawing.Point(235, 11);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(50, 50);
            this.clearButton.TabIndex = 5;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(403, 11);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(50, 50);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.maximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("maximizeButton.Image")));
            this.maximizeButton.Location = new System.Drawing.Point(347, 11);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(50, 50);
            this.maximizeButton.TabIndex = 4;
            this.maximizeButton.UseVisualStyleBackColor = false;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(291, 11);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(50, 50);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // penButton2
            // 
            this.penButton2.Image = ((System.Drawing.Image)(resources.GetObject("penButton2.Image")));
            this.penButton2.Location = new System.Drawing.Point(67, 11);
            this.penButton2.Name = "penButton2";
            this.penButton2.Size = new System.Drawing.Size(50, 50);
            this.penButton2.TabIndex = 1;
            this.penButton2.UseVisualStyleBackColor = true;
            this.penButton2.Click += new System.EventHandler(this.penButton2_Click);
            // 
            // penButton1
            // 
            this.penButton1.Image = ((System.Drawing.Image)(resources.GetObject("penButton1.Image")));
            this.penButton1.Location = new System.Drawing.Point(11, 11);
            this.penButton1.Name = "penButton1";
            this.penButton1.Size = new System.Drawing.Size(50, 50);
            this.penButton1.TabIndex = 0;
            this.penButton1.UseVisualStyleBackColor = true;
            this.penButton1.Click += new System.EventHandler(this.penButton1_Click);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.LargeChange = 10;
            this.trackBarGreen.Location = new System.Drawing.Point(3, 19);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Minimum = 1;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(227, 56);
            this.trackBarGreen.TabIndex = 3;
            this.trackBarGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGreen.Value = 1;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBarRed
            // 
            this.trackBarRed.LargeChange = 10;
            this.trackBarRed.Location = new System.Drawing.Point(3, 3);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Minimum = 1;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(227, 56);
            this.trackBarRed.TabIndex = 4;
            this.trackBarRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRed.Value = 1;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.LargeChange = 10;
            this.trackBarBlue.Location = new System.Drawing.Point(3, 35);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Minimum = 1;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(227, 56);
            this.trackBarBlue.TabIndex = 5;
            this.trackBarBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBlue.Value = 1;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.colorPanel.Controls.Add(this.colorPreview);
            this.colorPanel.Controls.Add(this.trackBarBlue);
            this.colorPanel.Controls.Add(this.trackBarGreen);
            this.colorPanel.Controls.Add(this.trackBarRed);
            this.colorPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorPanel.Location = new System.Drawing.Point(728, 0);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(319, 72);
            this.colorPanel.TabIndex = 6;
            // 
            // colorPreview
            // 
            this.colorPreview.Location = new System.Drawing.Point(258, 7);
            this.colorPreview.Name = "colorPreview";
            this.colorPreview.Size = new System.Drawing.Size(55, 55);
            this.colorPreview.TabIndex = 6;
            // 
            // sizePanel
            // 
            this.sizePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sizePanel.Controls.Add(this.label1);
            this.sizePanel.Controls.Add(this.sizeTrackBar);
            this.sizePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sizePanel.Location = new System.Drawing.Point(497, 0);
            this.sizePanel.Name = "sizePanel";
            this.sizePanel.Size = new System.Drawing.Size(231, 72);
            this.sizePanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.sizePanel);
            this.panel3.Controls.Add(this.colorPanel);
            this.panel3.Controls.Add(this.controlsPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1510, 72);
            this.panel3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 735);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.canvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).EndInit();
            this.controlsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.colorPanel.ResumeLayout(false);
            this.colorPanel.PerformLayout();
            this.sizePanel.ResumeLayout(false);
            this.sizePanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.TrackBar sizeTrackBar;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Button penButton1;
        private System.Windows.Forms.Button penButton2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Panel colorPreview;
        private System.Windows.Forms.Panel sizePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button eraserButton;
        private System.Windows.Forms.Button penButton;
    }
}

