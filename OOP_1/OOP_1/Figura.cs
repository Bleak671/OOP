using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing;

namespace OOP_1
{
    public abstract class Figura : object
    {
        public abstract int Draw(PictureBox picture);
    }
}
