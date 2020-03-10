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
        public Color clr { get; set; }
        public void Draw(PictureBox picture, Color color)
        {
            Graphics graph = picture.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(color);
            graph.DrawEllipse(pen, Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2) - Convert.ToInt32(x1), Convert.ToInt32(y2) - Convert.ToInt32(y1));
            graph.FillEllipse(brush, Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2) - Convert.ToInt32(x1), Convert.ToInt32(y2) - Convert.ToInt32(y1));
            graph.Dispose();
            pen.Dispose();
            brush.Dispose();
        }
    }
}
