using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace OOP_1
{
    public partial class Form1 : Form
    {
        ObjList olist = new ObjList();
        Color intcolor = new Color();
        Color extcolor = new Color();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int[] dots = new int[16];
            dots[1] = Convert.ToInt32(textX1.Text);
            dots[2] = Convert.ToInt32(textY1.Text);
            dots[3] = Convert.ToInt32(textX2.Text);
            dots[4] = Convert.ToInt32(textY2.Text);

            String tmp = "OOP_1." + this.cmb1.SelectedItem;
            Type mytype = Type.GetType(tmp, false, true);

            if (mytype != null)
            {
                //получаем конструктор
                System.Reflection.ConstructorInfo ci = mytype.GetConstructor(new Type[] { typeof(int[]), typeof(Color), typeof(Color) });

                //вызываем конструтор
                object obj = ci.Invoke(new object[] { dots, intcolor, extcolor });
                olist.list.Add((Figura)obj);
            }
            else
            {
                Console.WriteLine("Класс не найден");
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            foreach (object o in olist.list)
            {
                Figura tmp = (Figura)o;
                if (tmp.Draw(picture) == 1)
                {
                    MessageBox.Show("Failed to draw");
                }           
            }       
        }

        public struct Item
        {
            public int x1, x2, y1, y2;
            public string type;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            olist.list.Clear();
        }

        private void btnPage_Click(object sender, EventArgs e)
        {
            picture.Image = null;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                intcolor = colorDialog1.Color;
                textBox1.BackColor = intcolor;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                extcolor = colorDialog2.Color;
                textBox2.BackColor = extcolor;
            }
        }
    }
}