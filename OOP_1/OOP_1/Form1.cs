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
using System.Reflection;
using System.IO;

namespace OOP_1
{
    public partial class Form1 : Form
    {
        struct constr
        {
            public string Name;
            public ConstructorInfo cinf;
        };
        String path;
        ObjList olist = new ObjList();
        List<constr> coll = new List<constr>();
        Color intcolor = new Color();
        Color extcolor = new Color();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int[] dots = new int[16];
            dots[0] = Convert.ToInt32(textX1.Text);
            dots[1] = Convert.ToInt32(textY1.Text);
            dots[2] = Convert.ToInt32(textX2.Text);
            dots[3] = Convert.ToInt32(textY2.Text);
            dots[4] = Convert.ToInt32(textX3.Text);
            dots[5] = Convert.ToInt32(textY3.Text);
            dots[6] = Convert.ToInt32(textX4.Text);
            dots[7] = Convert.ToInt32(textY4.Text);
            dots[8] = Convert.ToInt32(textX5.Text);
            dots[9] = Convert.ToInt32(textY5.Text);
            dots[10] = Convert.ToInt32(textX6.Text);
            dots[11] = Convert.ToInt32(textY6.Text);
            dots[12] = Convert.ToInt32(textX7.Text);
            dots[13] = Convert.ToInt32(textY7.Text);
            dots[14] = Convert.ToInt32(textX8.Text);
            dots[15] = Convert.ToInt32(textY8.Text);

            foreach (constr co in coll)
            {
                if (String.Compare(co.Name,cmb1.SelectedItem.ToString()) == 0)
                {
                    object obj = co.cinf.Invoke(new object[] { dots, intcolor, extcolor });
                    olist.list.Add((Figura)obj);
                }
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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmb1.Items.Clear();
            coll.Clear();
            Type[] types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.BaseType == typeof(Figura)).ToArray();
            foreach (Type t in types)
            {
                this.cmb1.Items.Add(t.ToString().Remove(0,6));
                Type mytype = Type.GetType(t.ToString(), false, true);

                //получаем конструктор
                ConstructorInfo ci = mytype.GetConstructor(new Type[] { typeof(int[]), typeof(Color), typeof(Color) });
                //вызываем конструтор
                constr elem;
                elem.Name = t.ToString().Remove(0, 6);
                elem.cinf = ci;

                //вызываем конструтор
                coll.Add(elem);
            }
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
            }
            FileStream file = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(file);
            foreach (Figura o in olist.list)
            {
                sw.WriteLine(o.GetType().ToString());
                int[] arr = o.GetBytes();
                foreach (int i in arr)
                {
                    sw.Write(i.ToString() + ",");
                }
                sw.WriteLine();
                sw.WriteLine(o.GetExtClr().ToArgb().ToString());
                sw.WriteLine(o.GetIntClr().ToArgb().ToString());
            }
            sw.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
            }

            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(file);
            String tmp, s ="";
            char c;
            int i, num = 0;
            int[] dots = new int[16];
            Type mytype;
            olist.list.Clear();
            while (!sw.EndOfStream)
            {
                tmp = sw.ReadLine();
                mytype = Type.GetType(tmp, false, true);

                tmp = sw.ReadLine();
                for (i = 0; i <= tmp.Length - 1; i++)
                {
                    c = tmp[i];
                    if (String.Compare(c.ToString(),",") == 0)
                    {
                        dots[num] = Convert.ToInt32(s);
                        s = "";
                        num++; 
                    }
                    else
                    {
                        s += c;
                    }
                }

                tmp = sw.ReadLine();
                extcolor = Color.FromArgb(Convert.ToInt32(tmp));

                tmp = sw.ReadLine();
                intcolor = Color.FromArgb(Convert.ToInt32(tmp));

                //получаем конструктор
                System.Reflection.ConstructorInfo ci = mytype.GetConstructor(new Type[] { typeof(int[]), typeof(Color), typeof(Color) });

                //вызываем конструтор
                object obj = ci.Invoke(new object[] { dots, intcolor, extcolor });
                olist.list.Add((Figura)obj);
            }
        }

        private void btnLib_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "DLL-files(*.dll)|*.dll|All files(*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string libpath = openFileDialog1.FileName;
                try
                {
                    Assembly asm = Assembly.LoadFrom(libpath);

                    Type[] types = asm.GetTypes().Where(t => t.BaseType == typeof(Figura)).ToArray();

                    foreach (Type t in types)
                    {
                        this.cmb1.Items.Add(t.ToString().Remove(0, 6));

                        //получаем конструктор
                        ConstructorInfo ci = t.GetConstructor(new Type[] { typeof(int[]), typeof(Color), typeof(Color) });

                        constr elem;
                        elem.Name = t.ToString().Remove(0, 6);
                        elem.cinf = ci;

                        //вызываем конструтор
                        coll.Add(elem);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка подключения dll");
                }
            }

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
    }
}