using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows;
using System.Runtime.InteropServices;

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
        private Point startPosition;
        private Point endPosition;
        int screenLeft = SystemInformation.VirtualScreen.Left;
        int screenTop = SystemInformation.VirtualScreen.Top;
        int screenWidth = SystemInformation.VirtualScreen.Width;
        int screenHeight = SystemInformation.VirtualScreen.Height;

        [StructLayout(LayoutKind.Sequential)]
        public struct DEVMODE
        {
            private const int CCHDEVICENAME = 0x20;
            private const int CCHFORMNAME = 0x20;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmDeviceName;
            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;
            public int dmPositionX;
            public int dmPositionY;
            public ScreenOrientation dmDisplayOrientation;
            public int dmDisplayFixedOutput;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmFormName;
            public short dmLogPixels;
            public int dmBitsPerPel;
            public int dmPelsWidth;
            public int dmPelsHeight;
            public int dmDisplayFlags;
            public int dmDisplayFrequency;
            public int dmICMMethod;
            public int dmICMIntent;
            public int dmMediaType;
            public int dmDitherType;
            public int dmReserved1;
            public int dmReserved2;
            public int dmPanningWidth;
            public int dmPanningHeight;
        }
        [DllImport("user32.dll")]
        public static extern bool EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref DEVMODE lpDevMode);

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

            Button[] buttons = { penButton1, penButton2, penButton, eraserButton, saveButton, clearButton, minimizeButton, maximizeButton, closeButton };
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
            startPosition = e.Location;
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
                    Point startPoint1 = e.Location;
                    startPoint1.Offset(-1, 0);
                    lines.Add(new Line(startPoint1, e.Location, currentPen.Color, currentPen.Width));
                }
            }
        }

        private void RedrawLines()
        {
            using (Graphics g = canvas.CreateGraphics())
            {
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
        }


        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            endPosition = e.Location;
        }

        private void penButton1_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.FromArgb(255, 255, 255, 255);
            currentPen.Width = 5;
        }

        private void penButton2_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.FromArgb(255, 0, 0, 0);
            currentPen.Width = 5;
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
            numericUpDown1.Value = (decimal)currentPen.Width;
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
            currentPen.Color = colorDialog.Color;
            currentPen.Width = (float)numericUpDown1.Value;
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            Screen currentScreen = Screen.FromHandle(this.Handle);
            DEVMODE dm = new DEVMODE();
            dm.dmSize = (short)Marshal.SizeOf(typeof(DEVMODE));
            EnumDisplaySettings(currentScreen.DeviceName, -1, ref dm);

            var scalingFactor = Math.Round(Decimal.Divide(dm.dmPelsWidth, currentScreen.Bounds.Width), 2);
            Console.WriteLine("Current Screen Scaling Factor: " + scalingFactor);
            Screen activeScreen = Screen.FromHandle(this.Handle);

            Bitmap screenshot = new Bitmap((int)(activeScreen.Bounds.Width * scalingFactor),
                (int)(activeScreen.Bounds.Height * scalingFactor),
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics gfxScreenshot = Graphics.FromImage(screenshot))
            {
                gfxScreenshot.CopyFromScreen(
                    (int)(activeScreen.Bounds.X * scalingFactor),
                    (int)(activeScreen.Bounds.Y * scalingFactor),
                    0,
                    0,
                    new Size((int)(activeScreen.Bounds.Width * scalingFactor), (int)(activeScreen.Bounds.Height * scalingFactor)),
                    CopyPixelOperation.SourceCopy);
    }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PNG Image|*.png";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    screenshot.Save(saveDialog.FileName, ImageFormat.Png);
                }
            }
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void color_selecter_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                currentPen.Color = selectedColor;
            }

            currentPen.Color = colorDialog.Color;

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

        private void button1_Click(object sender, EventArgs e)
        {
            currentPen.Width = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentPen.Width = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentPen.Width = 6;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            currentPen.Width = (float)numericUpDown1.Value;
            sizeTrackBar.Value = (int)currentPen.Width;
        }
    }
}
