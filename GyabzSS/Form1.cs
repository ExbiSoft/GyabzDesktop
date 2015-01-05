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

namespace GyabzSS
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;
        Graphics screenCap;
        string saveTo;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnScreenCap_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
                Thread.Sleep(500); //hides screenshot box to get capture of screen
                g = this.CreateGraphics(); //creates instance for image graphics
                bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, g); //sets bitmap to size of screen
                screenCap = Graphics.FromImage(bmp); //creates new graphics for image
                saveTo = saveFileDialog1.FileName; //stores save location for screenshot
                screenCap.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size); //captures current screen
                bmp.Save(saveTo); //saves screenshot
                this.Show(); //shows screenshot box again
            }
        }
    }
}
