using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_1
{
    public class Rectangle : Figura
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
                graph.DrawRectangle(pen, dots[0], dots[1], dots[2] - dots[0], dots[3] - dots[1]);
                graph.FillRectangle(brush, dots[0] + 1, dots[1] + 1, dots[2] - dots[0] - 1, dots[3] - dots[1] - 1);
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
        public Rectangle(int[] coords, Color intclr, Color extclr)
        {
            dots = coords;
            externclr = extclr;
            internclr = intclr;
        }

        public override int[] GetBytes()
        {
            return dots;
        }

        public override Color GetIntClr()
        {
            return internclr;
        }

        public override Color GetExtClr()
        {
            return externclr;
        }
    }
}
