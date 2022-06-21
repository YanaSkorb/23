using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace задание_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pen pen = new Pen(Color.Black, 2);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            g.DrawLine(pen, 120, 400, 120, 250);
            g.DrawLine(pen, 280, 400, 280, 50);
            g.DrawLine(pen, 120, 250, 280, 250);
        }

    }
}
