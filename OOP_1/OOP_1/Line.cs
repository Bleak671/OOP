using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_1
{
    public class Line : Figura
    {
        public int[] dots;
        public Color externclr { get; set; }
        public override int Draw(PictureBox picture)
        {
            try
            {
                Graphics graph = picture.CreateGraphics();
                Pen pen = new Pen(externclr);
                graph.DrawLine(pen, dots[0], dots[1], dots[2], dots[3]);
                graph.Dispose();
                pen.Dispose();
                return 0;
            }
            catch
            {
                return 1;
            }
        }

        public Line(int[] coords, Color intclr, Color extclr)
        {
            dots = coords;
            externclr = extclr;
        }

        public override int[] GetBytes()
        {
            return dots;
        }

        public override Color GetIntClr()
        {
            return Color.Black;
        }

        public override Color GetExtClr()
        {
            return externclr;
        }
    }
}
