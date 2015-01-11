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
    public partial class Form1 : Form
    {
        private Bitmap bmp;
        private Graphics g;
        private Graphics screenCap;
        private string saveTo;
        private string tempPath;
        Form2 regionDraw = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnScreenCap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread.Sleep(500); //hides screenshot box to get capture of screen
            g = this.CreateGraphics();
            bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, g); 
            screenCap = Graphics.FromImage(bmp);
            tempPath = Path.GetTempPath(); //creates a temporary path to store screenshot
            saveTo = tempPath + IDgen() + ".png";
            screenCap.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size); //captures current screen
            bmp.Save(saveTo);
            this.Show(); 
        }

        private void btnAreaCap_Click(object sender, EventArgs e)
        {
            this.Hide();
            regionDraw.Show();
            regionDraw.activate();
            Application.Exit();
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
                switch(charType)
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
