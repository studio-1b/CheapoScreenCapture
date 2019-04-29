using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

using System.Runtime.InteropServices;


namespace CheapoScreenCapture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Retrieve the working rectangle from the Screen class
            // using the PrimaryScreen and the WorkingArea properties.
            System.Drawing.Rectangle workingRectangle =
                Screen.PrimaryScreen.WorkingArea;

            // Set the size of the form slightly less than size of 
            // working rectangle.
            wText.Text = workingRectangle.Width.ToString();
            hText.Text = workingRectangle.Height.ToString();

            _capture.Parent = this;
            _capture.CaptureHappened += new EventHandler<ScreenCapture.ImagEventArgs>(_capture_CaptureHappened);
        }

        void _capture_CaptureHappened(object sender, ScreenCapture.ImagEventArgs e)
        {

            if (this.InvokeRequired)
                this.BeginInvoke(new MethodInvoker(delegate()
                {
                    pictureBox1.Image = e.Bmp;
                    this.Text = _capture.Remaining.ToString();
                }));
            else
            {
                pictureBox1.Image = e.Bmp;
                this.Text = _capture.Remaining.ToString();
            }
        }


        ScreenCapture _capture = new ScreenCapture();

        private void captureBtn_Click(object sender, EventArgs e)
        {
            previewCaptureArea_Click(sender, e);

            var dir = new DirectoryInfo(Environment.CurrentDirectory);
            foreach (var file in dir.EnumerateFiles("cap*.png"))
                file.Delete();

            int fps = 0;
            if (int.TryParse(framerateText.Text, out fps))
                _capture.Capture.Interval = fps;
            else
            {
                MessageBox.Show("Framerate not a number");
                return;
            }

            int sec = 0;
            if (int.TryParse(secondsText.Text, out sec))
                _capture.TerminateAt = sec * fps;
            else
            {
                MessageBox.Show("Capture for n seconds, not a number");
                return;
            }

            _capture.Reset();
            _capture.Capture.Start();
        }

        private void captureBtn_Move(object sender, EventArgs e)
        {
           // _capture.CaptureBounds = this.Bounds;
        }

        private void captureBtn_Resize(object sender, EventArgs e)
        {
           // _capture.CaptureBounds = this.Bounds;
        }

        private void previewCaptureArea_Click(object sender, EventArgs e)
        {
            int x = 0;
            if (!int.TryParse(xText.Text, out x))
            {
                MessageBox.Show("x not a number");
                return;
            }
            int y = 0;
            if (!int.TryParse(yText.Text, out y))
            {
                MessageBox.Show("y not a number");
                return;
            }
            int w = 0;
            if (!int.TryParse(wText.Text, out w))

            {
                MessageBox.Show("w not a number");
                return;
            }
            int h = 0;
            if (int.TryParse(hText.Text, out h))
                _capture.Capture.Interval = h;
            else
            {
                MessageBox.Show("h not a number");
                return;
            }
            if (pictureBox1.Image != null)
            {
                var old = pictureBox1.Image;
                pictureBox1.Image = null;
                old.Dispose();
            }
            var rect = new Rectangle(x, y, w, h);
            _capture.CaptureBounds = rect;
            _capture.CaptureAt(rect);
            

            if (sender == this.previewCaptureArea)
                WindowsScreen.Singleton.Draw(rect);
            
        }

    }

    public class ScreenCapture 
    {
        public ScreenCapture()
        {
            this.Capture.Tick += new EventHandler(Capture_Tick);
        }

        public Form Parent;

        void Capture_Tick(object sender, EventArgs e)
        {
            if (_index >= this.TerminateAt)
                this.Capture.Stop();

            if (Parent.InvokeRequired)
                Parent.Invoke(new MethodInvoker(delegate()
                {
                    this.SaveAt(this.CaptureBounds);
                }));
            else
                this.SaveAt(this.CaptureBounds);
        }

        public readonly Timer Capture = new Timer();
        int _index = 0;
        public int TerminateAt;

        public void Reset()
        {
            _index = 0;
        }

        public int Remaining { get { return TerminateAt - _index; } }

        public Rectangle CaptureBounds = default(Rectangle);

        /// <summary>
        /// Reference design
        /// https://stackoverflow.com/questions/1163761/capture-screenshot-of-active-window
        /// </summary>
        public void SaveWindow() 
        {
            var bounds = this.Parent.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left,bounds.Top), Point.Empty, bounds.Size);
                }
                var name = string.Format("cap{0:00000}.png", _index++);
                bitmap.Save(name, ImageFormat.Png);
            }
        }

        public Bitmap CaptureAt(Rectangle bounds)
        {
            Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
            }
            
            if (this.CaptureHappened != null)
                this.CaptureHappened(this, new ImagEventArgs() { Bmp = bitmap });

            return bitmap;
        }

        public void SaveAt(Rectangle bounds)
        {
            var bmp = CaptureAt(bounds);
            var name = string.Format("cap{0:00000}.png", _index++);
            bmp.Save(name, ImageFormat.Png);
        }

        public class ImagEventArgs : EventArgs 
        {
            public Bitmap Bmp;
        }
        public event EventHandler<ImagEventArgs> CaptureHappened;
    }


    public class WindowsScreen
    {
        static public WindowsScreen Singleton = new WindowsScreen();



        [DllImport("User32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("User32.dll")]
        static extern void ReleaseDC(IntPtr hwnd, IntPtr dc);

        public void Draw(Rectangle location)
        {
            IntPtr desktopPtr = GetDC(IntPtr.Zero);
            try
            {
                using (Graphics g = Graphics.FromHdc(desktopPtr))
                {
                    //var size = g.ClipBounds;
                    //g.FillRectangle(Brushes.DarkGray, size);
                    //size.Width-=2;
                    //size.Height-=2;
                    //size.X=1;
                    //size.Y=1;
                    var size = location.Size;
                    //var place = new Rectangle(new Point(0, 0), size);
                    g.FillRectangle(Brushes.Red, location);
                    g.DrawRectangle(Pens.Blue, location);
                }
            }
            finally
            {
                ReleaseDC(IntPtr.Zero, desktopPtr);
            }
        }
    }


}
