using System;
using System.Drawing;

namespace OOPDraw
{
    public class Line : IDisposable
    {
        public Pen Pen { get; }
        public int X1 { get; }
        public int Y1 { get; }
        public int X2 { get; private set; }
        public int Y2 { get; private set; }

        public Line(Pen p, int x1, int y1, int x2, int y2)
        {
            Pen = (Pen)p.Clone();   // 🔴 FIX: each line owns its own pen
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public Line(Pen p, int x1, int y1)
            : this(p, x1, y1, x1, y1)
        {
        }

        public void GrowTo(int x2, int y2)
        {
            X2 = x2;
            Y2 = y2;
        }

        public void Draw(Graphics g)
        {
            g.DrawLine(Pen, X1, Y1, X2, Y2);
        }

        public void Dispose()
        {
            Pen.Dispose();
        }
    }
}
