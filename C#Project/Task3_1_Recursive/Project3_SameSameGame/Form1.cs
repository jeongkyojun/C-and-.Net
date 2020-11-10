using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_SameSameGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Graphics picGr;
            Pen penTmp;

            int i;
            int r, g, b;
            Random md = new Random();
            r = md.Next(256);
            g = md.Next(256);
            b = md.Next(256);

            penTmp = new Pen(Color.FromArgb(r, g, b), 1);
            //Draw line to screen
            picGr = picTest.CreateGraphics();

            for(i=0;i<picTest.Width;i++)
            {
                picGr.DrawLine(penTmp, i, 0, i,picTest.Height);
                System.Threading.Thread.Sleep(10);
                Application.DoEvents();
            }
        }
    }
}
