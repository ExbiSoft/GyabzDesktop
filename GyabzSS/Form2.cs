using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Imaging;
using System.IO;

namespace GyabzSS
{
    public partial class Form2 : Form
    {
        private bool isDown = false;
        private bool active = false;
        private Rectangle rect;
        private int startX;
        private int startY;
        private Bitmap bmp;
        private Graphics g;
        private Graphics screenCap;
        private string saveTo;
        private string tempPath;

        public Form2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MinimumSize = this.Size;
            this.Opacity = 0.1;
        }

        public void activate()
        {
            active = true;
        }

        private void canvas(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(new Pen(Color.Black), rect);
        }

        private void onMouseDown(object sender, MouseEventArgs e)
        {
            if (active)
            {
                startX = e.X;
                startY = e.Y;
                isDown = true;
            }
        }

        private void onMove(object sender, MouseEventArgs e)
        {
            if (active)
            {
                if (isDown)
                {
                    rect = new Rectangle(Math.Min(startX, e.X), Math.Min(startY, e.Y), Math.Abs(e.X - startX), Math.Abs(e.Y - startY));
                    this.Invalidate();
                }
            }
        }

        private void onMouseUp(object sender, MouseEventArgs e)
        {
            if (active)
            {
                isDown = false;
                Thread.Sleep(100);
                this.Hide();
                captureRegion(e.X, e.Y);
            }
        }

        private void captureRegion(int endX, int endY)
        {
            Size size = new Size(Math.Abs(endX - startX), Math.Abs(endY - startY));
            g = this.CreateGraphics();
            bmp = new Bitmap(Math.Abs(endX - startX), Math.Abs(endY - startY), g);
            screenCap = Graphics.FromImage(bmp);
            tempPath = Path.GetTempPath(); //creates a temporary path to store screenshot
            saveTo = tempPath + IDgen() + ".png";
            screenCap.CopyFromScreen(Math.Min(startX, endX), Math.Min(startY, endY), 0, 0, size); //captures current screen
            bmp.Save(saveTo);

            this.Close();
            new Form1().Show();
        }

        private string IDgen()
        {
            //a function that returns a random filename
            //generated from ascii values
            string ID = "";
            char nextChar = ' ';
            int charType;

            Random rand = new Random();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 16; i++)
            {
                charType = rand.Next(1, 4);
                switch (charType)
                {
                    case 1:
                        nextChar = (char)rand.Next(48, 57);
                        break;
                    case 2:
                        nextChar = (char)rand.Next(65, 90);
                        break;
                    case 3:
                        nextChar = (char)rand.Next(97, 122);
                        break;
                    default:
                        MessageBox.Show("An error has occurred");
                        break;
                }
                sb.Insert(i, nextChar);
            }
            ID = sb.ToString();
            return ID;
        }
    }
}
