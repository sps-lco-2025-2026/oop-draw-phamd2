using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPDraw
{
    public partial class OOPDraw : Form
    {
        public OOPDraw()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        Pen currentPen = new Pen(Color.Black);
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Point a = new Point(20, 30);
            Point b = new Point(400, 500);
            Point c = new Point(400, 100);
            gr.DrawLine(currentPen, a, b);
            gr.DrawLine(currentPen, b, c);
            gr.DrawLine(currentPen, c, a);
        }
    }
}
