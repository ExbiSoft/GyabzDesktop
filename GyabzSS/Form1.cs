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
        string saveTo;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnScreenCap_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Width); //sets bitmap to size of screen

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveTo = saveFileDialog1.FileName; //stores save location for screenshot
                this.Hide();
                Thread.Sleep(500); //hides screenshot box to get capture of screen
                //take screenshot here

                this.Show(); //shows screenshot box again
            }
        }
    }
}
