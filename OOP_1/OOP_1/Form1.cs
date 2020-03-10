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
        Color color = new Color();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (this.cmb1.SelectedItem)
            {
                case "Line":
                    Line line = new Line();
                    line.x1 = textX1.Text;
                    line.x2 = textX2.Text;
                    line.y1 = textY1.Text;
                    line.y2 = textY2.Text;
                    olist.list.Add(line);
                    line = null;
                    break;
                case "Rectangle":
                    Rectangle rect = new Rectangle();
                    rect.x1 = textX1.Text;
                    rect.x2 = textX2.Text;
                    rect.y1 = textY1.Text;
                    rect.y2 = textY2.Text;
                    rect.clr = color;
                    olist.list.Add(rect);
                    rect = null;
                    break;
                case "Ellipse":
                    Ellipse ell = new Ellipse();
                    ell.x1 = textX1.Text;
                    ell.x2 = textX2.Text;
                    ell.y1 = textY1.Text;
                    ell.y2 = textY2.Text;
                    ell.clr = color;
                    olist.list.Add(ell);
                    ell = null;
                    break;
                default:
                    break;
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            foreach (object o in olist.list)
            {
                if (o is Line)
                {
                    Line tmp = (Line)o;
                    tmp.Draw(picture);
                }
                if (o is Rectangle)
                {
                    Rectangle tmp = (Rectangle)o;
                    tmp.Draw(picture, tmp.clr);
                }
                if (o is Ellipse)
                {
                    Ellipse tmp = (Ellipse)o;
                    tmp.Draw(picture, tmp.clr);
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
                color = colorDialog1.Color;
                textBox1.BackColor = color;
            }
        }
    }
}