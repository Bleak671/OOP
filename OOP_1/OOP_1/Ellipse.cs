using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_1
{

    public class Ellipse : Figura
    {
        public int[] dots;
        public Color internclr { get; set; }
        public Color externclr { get; set; }
        public override int Draw(PictureBox picture)
        {
            try
            {
                Graphics graph = picture.CreateGraphics();
                Pen pen = new Pen(externclr);
                SolidBrush brush = new SolidBrush(internclr);
                graph.DrawEllipse(pen, dots[1], dots[2], dots[3] - dots[1], dots[4] - dots[2]);
                graph.FillEllipse(brush, dots[1], dots[2], dots[3] - dots[1], dots[4] - dots[2]);
                graph.Dispose();
                pen.Dispose();
                brush.Dispose();
                return 0;
            }
            catch
            {
                return 1;
            }
        }
        public Ellipse(int[] coords, Color intclr, Color extclr)
        {
            dots = coords;
            externclr = extclr;
            internclr = intclr;
        }
    }
}
