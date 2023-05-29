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
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.penButton = new System.Windows.Forms.Button();
            this.eraserButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.penButton2 = new System.Windows.Forms.Button();
            this.penButton1 = new System.Windows.Forms.Button();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.sizePanel = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.color_selecter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.controlsPanel.SuspendLayout();
            this.colorPanel.SuspendLayout();
            this.sizePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.Transparent;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1132, 597);
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // controlsPanel
            // 
            this.controlsPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.controlsPanel.Controls.Add(this.saveButton);
            this.controlsPanel.Controls.Add(this.penButton);
            this.controlsPanel.Controls.Add(this.eraserButton);
            this.controlsPanel.Controls.Add(this.clearButton);
            this.controlsPanel.Controls.Add(this.closeButton);
            this.controlsPanel.Controls.Add(this.maximizeButton);
            this.controlsPanel.Controls.Add(this.minimizeButton);
            this.controlsPanel.Controls.Add(this.penButton2);
            this.controlsPanel.Controls.Add(this.penButton1);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlsPanel.Location = new System.Drawing.Point(740, 0);
            this.controlsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(392, 58);
            this.controlsPanel.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(178, 9);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(38, 41);
            this.saveButton.TabIndex = 8;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // penButton
            // 
            this.penButton.Image = ((System.Drawing.Image)(resources.GetObject("penButton.Image")));
            this.penButton.Location = new System.Drawing.Point(92, 9);
            this.penButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.penButton.Name = "penButton";
            this.penButton.Size = new System.Drawing.Size(38, 41);
            this.penButton.TabIndex = 7;
            this.penButton.UseVisualStyleBackColor = true;
            this.penButton.Click += new System.EventHandler(this.penButton_Click);
            // 
            // eraserButton
            // 
            this.eraserButton.Image = ((System.Drawing.Image)(resources.GetObject("eraserButton.Image")));
            this.eraserButton.Location = new System.Drawing.Point(134, 9);
            this.eraserButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Size = new System.Drawing.Size(38, 41);
            this.eraserButton.TabIndex = 6;
            this.eraserButton.UseVisualStyleBackColor = true;
            this.eraserButton.Click += new System.EventHandler(this.eraserButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
            this.clearButton.Location = new System.Drawing.Point(220, 9);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(38, 41);
            this.clearButton.TabIndex = 5;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(346, 9);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(38, 41);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.maximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("maximizeButton.Image")));
            this.maximizeButton.Location = new System.Drawing.Point(304, 9);
            this.maximizeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(38, 41);
            this.maximizeButton.TabIndex = 4;
            this.maximizeButton.UseVisualStyleBackColor = false;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(262, 9);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(38, 41);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // penButton2
            // 
            this.penButton2.Image = ((System.Drawing.Image)(resources.GetObject("penButton2.Image")));
            this.penButton2.Location = new System.Drawing.Point(50, 9);
            this.penButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.penButton2.Name = "penButton2";
            this.penButton2.Size = new System.Drawing.Size(38, 41);
            this.penButton2.TabIndex = 1;
            this.penButton2.UseVisualStyleBackColor = true;
            this.penButton2.Click += new System.EventHandler(this.penButton2_Click);
            // 
            // penButton1
            // 
            this.penButton1.Image = ((System.Drawing.Image)(resources.GetObject("penButton1.Image")));
            this.penButton1.Location = new System.Drawing.Point(8, 9);
            this.penButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.penButton1.Name = "penButton1";
            this.penButton1.Size = new System.Drawing.Size(38, 41);
            this.penButton1.TabIndex = 0;
            this.penButton1.UseVisualStyleBackColor = true;
            this.penButton1.Click += new System.EventHandler(this.penButton1_Click);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.colorPanel.Controls.Add(this.color_selecter);
            this.colorPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorPanel.Location = new System.Drawing.Point(683, 0);
            this.colorPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(57, 58);
            this.colorPanel.TabIndex = 6;
            // 
            // sizePanel
            // 
            this.sizePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sizePanel.Controls.Add(this.button3);
            this.sizePanel.Controls.Add(this.button2);
            this.sizePanel.Controls.Add(this.button1);
            this.sizePanel.Controls.Add(this.numericUpDown1);
            this.sizePanel.Controls.Add(this.label1);
            this.sizePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sizePanel.Location = new System.Drawing.Point(359, 0);
            this.sizePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sizePanel.Name = "sizePanel";
            this.sizePanel.Size = new System.Drawing.Size(324, 58);
            this.sizePanel.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(52, 9);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(82, 37);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.sizePanel);
            this.panel3.Controls.Add(this.colorPanel);
            this.panel3.Controls.Add(this.controlsPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1132, 58);
            this.panel3.TabIndex = 8;
            // 
            // color_selecter
            // 
            this.color_selecter.Image = ((System.Drawing.Image)(resources.GetObject("color_selecter.Image")));
            this.color_selecter.Location = new System.Drawing.Point(15, 9);
            this.color_selecter.Margin = new System.Windows.Forms.Padding(2);
            this.color_selecter.Name = "color_selecter";
            this.color_selecter.Size = new System.Drawing.Size(38, 41);
            this.color_selecter.TabIndex = 9;
            this.color_selecter.UseVisualStyleBackColor = true;
            this.color_selecter.Click += new System.EventHandler(this.color_selecter_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(147, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(189, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "4";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(231, 9);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 41);
            this.button3.TabIndex = 12;
            this.button3.Text = "6";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 597);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.canvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.controlsPanel.ResumeLayout(false);
            this.colorPanel.ResumeLayout(false);
            this.sizePanel.ResumeLayout(false);
            this.sizePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Button penButton1;
        private System.Windows.Forms.Button penButton2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Panel sizePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button eraserButton;
        private System.Windows.Forms.Button penButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button color_selecter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

