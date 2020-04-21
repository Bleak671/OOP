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
    public class Triangle : Figura
    {
        public int[] dots;
        public Color internclr { get; set; }
        public Color externclr { get; set; }
        public override int Draw(PictureBox picture)
        {
            try
            {
                Point[] arr = new Point[3];
                arr[0] = new Point(dots[0],dots[1]);
                arr[1] = new Point(dots[2], dots[3]);
                arr[2] = new Point(dots[4], dots[5]);
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
        public Triangle(int[] coords, Color intclr, Color extclr)
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

