using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;
using System.IO;


namespace OOP_1
{
    [Serializable]
    public class Polygon : Figura
    {
        public int[] dots;
        public Color internclr { get; set; }
        public Color externclr { get; set; }
        public override int Draw(PictureBox picture)
        {
            try
            {
                Point[] arr = new Point[dots.Length / 2];
                for (int i = 0; i < dots.Length / 2; i++)
                {
                    arr[i] = new Point(dots[2 * i], dots[2 * i + 1]);
                }
                Graphics graph = picture.CreateGraphics();
                Pen pen = new Pen(externclr);
                SolidBrush brush = new SolidBrush(internclr);
                graph.DrawPolygon(pen, arr);
                graph.FillPolygon(brush, arr);
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
        public Polygon(int[] coords, Color intclr, Color extclr)
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

