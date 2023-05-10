using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screendrawer_v2
{
    public partial class Form1 : Form
    {
        private bool isDrawing;
        private Point previousPoint;
        private Pen currentPen;
        private Color currentColor;
        private int currentSize;
        private bool isDragging = false;
        private Point offset;

        public Form1()
        {
            InitializeComponent();

            currentColor = Color.Black;
            currentSize = 1;
            currentPen = new Pen(currentColor, currentSize);

            canvas.MouseDown += new MouseEventHandler(canvas_MouseDown);
            canvas.MouseMove += new MouseEventHandler(canvas_MouseMove);
            canvas.MouseClick += new MouseEventHandler(canvas_MouseClick);
            canvas.MouseUp += new MouseEventHandler(canvas_MouseUp);
            panel3.MouseDown += new MouseEventHandler(panel3_MouseDown);
            panel3.MouseMove += new MouseEventHandler(panel3_MouseMove);
            panel3.MouseUp += new MouseEventHandler(panel3_MouseUp);

            this.BackColor = Color.FromArgb(255, 255, 255, 254);
            this.TransparencyKey = Color.FromArgb(255, 255, 255, 254);

            Resize += Form1_Resize;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorPreview.BackColor = Color.FromArgb(trackBarGreen.Value, currentPen.Color.G, currentPen.Color.B);
            this.WindowState = FormWindowState.Maximized;

            Button[] buttons = { penButton1, penButton2, penButton, eraserButton, clearButton, minimizeButton, maximizeButton, closeButton };
            foreach (Button button in buttons)
            {
                Image resizedImage = ResizeImage(button.Image, 25, 25);
                button.Image = resizedImage;
            }
            foreach (Button button in buttons)
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            }
        }

        private Image ResizeImage(Image originalImage, int newWidth, int newHeight)
        {
            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.DrawImage(originalImage, 0, 0, newWidth, newHeight);
            }
            return resizedImage;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                RedrawLines();
            }
            else if (WindowState == FormWindowState.Normal)
            {
                RedrawLines();
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                RedrawLines();
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offset = e.Location;
                WindowState = FormWindowState.Normal;
            }
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.Location;
                newLocation.X += e.X - offset.X;
                newLocation.Y += e.Y - offset.Y;
                this.Location = newLocation;
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                WindowState = FormWindowState.Maximized;
            }
        }


        private List<Line> lines = new List<Line>();

        public class Line
        {
            public Point StartPoint { get; set; }
            public Point EndPoint { get; set; }
            public Color PenColor { get; set; }
            public float PenWidth { get; set; }

            public Line(Point startPoint, Point endPoint, Color penColor, float penWidth)
            {
                StartPoint = startPoint;
                EndPoint = endPoint;
                PenColor = penColor;
                PenWidth = penWidth;
            }
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            previousPoint = e.Location;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = canvas.CreateGraphics())
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                    using (Pen smoothPen = new Pen(currentPen.Color, currentPen.Width))
                    {
                        smoothPen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                        smoothPen.StartCap = smoothPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                        g.DrawLine(smoothPen, previousPoint, e.Location);
                    }
                    lines.Add(new Line(previousPoint, e.Location, currentPen.Color, currentPen.Width));
                    previousPoint = e.Location;
                }
            }
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int halfWidth = (int)(currentPen.Width / 2f);

                using (Graphics g = canvas.CreateGraphics())
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

                    using (Brush brush = new SolidBrush(currentPen.Color))
                    {
                        int x = e.X - halfWidth;
                        int y = e.Y - halfWidth;
                        g.FillEllipse(brush, x, y, currentPen.Width, currentPen.Width);
                    }

                    lines.Add(new Line(new Point(e.X, e.Y), new Point(e.X, e.Y), currentPen.Color, currentPen.Width));
                }
            }
        }

        private void RedrawLines()
        {
            Graphics g = canvas.CreateGraphics();
            g.SmoothingMode = SmoothingMode.None;
            foreach (var line in lines)
            {
                using (Pen p = new Pen(line.PenColor, line.PenWidth))
                {
                    p.LineJoin = LineJoin.Round;
                    p.StartCap = p.EndCap = LineCap.Round;
                    g.DrawLine(p, line.StartPoint, line.EndPoint);
                }
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void penButton1_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.FromArgb(255, 255, 255, 255);
        }

        private void penButton2_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.FromArgb(255, 0, 0, 0);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;


        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sizeTrackBar_Scroll(object sender, EventArgs e)
        {
            currentSize = sizeTrackBar.Value;
            currentPen.Width = currentSize;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            currentPen.Color = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            colorPreview.BackColor = currentPen.Color;

            Image buttonImage = penButton.Image;
            Bitmap originalImage = new Bitmap(buttonImage);
            Bitmap modifiedImage = new Bitmap(originalImage.Width, originalImage.Height);
            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);
                    int red = currentPen.Color.R;
                    int green = currentPen.Color.G;
                    int blue = currentPen.Color.B;
                    Color newColor = Color.FromArgb(pixelColor.A, red, green, blue);
                    modifiedImage.SetPixel(x, y, newColor);
                }
            }
            penButton.Image = modifiedImage;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            currentPen.Color = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            colorPreview.BackColor = currentPen.Color;

            Image buttonImage = penButton.Image;
            Bitmap originalImage = new Bitmap(buttonImage);
            Bitmap modifiedImage = new Bitmap(originalImage.Width, originalImage.Height);
            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);
                    int red = currentPen.Color.R;
                    int green = currentPen.Color.G;
                    int blue = currentPen.Color.B;
                    Color newColor = Color.FromArgb(pixelColor.A, red, green, blue);
                    modifiedImage.SetPixel(x, y, newColor);
                }
            }
            penButton.Image = modifiedImage;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentPen.Color = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            colorPreview.BackColor = currentPen.Color;

            Image buttonImage = penButton.Image;
            Bitmap originalImage = new Bitmap(buttonImage);
            Bitmap modifiedImage = new Bitmap(originalImage.Width, originalImage.Height);
            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);
                    int red = currentPen.Color.R;
                    int green = currentPen.Color.G;
                    int blue = currentPen.Color.B;
                    Color newColor = Color.FromArgb(pixelColor.A, red, green, blue);
                    modifiedImage.SetPixel(x, y, newColor);
                }
            }
            penButton.Image = modifiedImage;
        }

        private void penButton_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void eraserButton_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.FromArgb(255, 255, 255, 254);

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            canvas.Refresh();
            lines.Clear();
        }
    }
}
