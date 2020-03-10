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
        public void Draw(PictureBox picture)
        {
            Graphics graph = picture.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            graph.DrawLine(pen, Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2), Convert.ToInt32(y2));
            graph.Dispose();
            pen.Dispose();
        }
    }
}
