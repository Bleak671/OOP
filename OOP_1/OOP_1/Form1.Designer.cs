namespace OOP_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.picture = new System.Windows.Forms.PictureBox();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.textX1 = new System.Windows.Forms.TextBox();
            this.textY1 = new System.Windows.Forms.TextBox();
            this.textX2 = new System.Windows.Forms.TextBox();
            this.textY2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.btnPage = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textY3 = new System.Windows.Forms.TextBox();
            this.textX3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textY4 = new System.Windows.Forms.TextBox();
            this.textX4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textY8 = new System.Windows.Forms.TextBox();
            this.textX8 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textY7 = new System.Windows.Forms.TextBox();
            this.textX7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textY6 = new System.Windows.Forms.TextBox();
            this.textX6 = new System.Windows.Forms.TextBox();
            this.textY5 = new System.Windows.Forms.TextBox();
            this.textX5 = new System.Windows.Forms.TextBox();
            this.btnLib = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(221, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(567, 487);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(12, 16);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(195, 21);
            this.cmb1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 290);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(184, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add in List";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(23, 337);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(184, 34);
            this.btnDraw.TabIndex = 3;
            this.btnDraw.Text = "Draw List";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // textX1
            // 
            this.textX1.Location = new System.Drawing.Point(35, 43);
            this.textX1.Name = "textX1";
            this.textX1.Size = new System.Drawing.Size(70, 20);
            this.textX1.TabIndex = 4;
            this.textX1.Text = "0";
            // 
            // textY1
            // 
            this.textY1.Location = new System.Drawing.Point(137, 43);
            this.textY1.Name = "textY1";
            this.textY1.Size = new System.Drawing.Size(70, 20);
            this.textY1.TabIndex = 5;
            this.textY1.Text = "0";
            // 
            // textX2
            // 
            this.textX2.Location = new System.Drawing.Point(35, 69);
            this.textX2.Name = "textX2";
            this.textX2.Size = new System.Drawing.Size(70, 20);
            this.textX2.TabIndex = 6;
            this.textX2.Text = "0";
            // 
            // textY2
            // 
            this.textY2.Location = new System.Drawing.Point(137, 69);
            this.textY2.Name = "textY2";
            this.textY2.Size = new System.Drawing.Size(70, 20);
            this.textY2.TabIndex = 7;
            this.textY2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "X2";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(35, 387);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(70, 28);
            this.btnList.TabIndex = 12;
            this.btnList.Text = "Clear List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnPage
            // 
            this.btnPage.Location = new System.Drawing.Point(136, 387);
            this.btnPage.Name = "btnPage";
            this.btnPage.Size = new System.Drawing.Size(70, 28);
            this.btnPage.TabIndex = 13;
            this.btnPage.Text = "Clear Page";
            this.btnPage.UseVisualStyleBackColor = true;
            this.btnPage.Click += new System.EventHandler(this.btnPage_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(35, 252);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(69, 24);
            this.btnColor.TabIndex = 14;
            this.btnColor.Text = "FillColor";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(18, 252);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(121, 256);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(10, 20);
            this.textBox2.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 24);
            this.button1.TabIndex = 17;
            this.button1.Text = "LineColor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 421);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 35);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(121, 421);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 35);
            this.btnLoad.TabIndex = 19;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "X3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Y3";
            // 
            // textY3
            // 
            this.textY3.Location = new System.Drawing.Point(137, 95);
            this.textY3.Name = "textY3";
            this.textY3.Size = new System.Drawing.Size(70, 20);
            this.textY3.TabIndex = 21;
            this.textY3.Text = "0";
            // 
            // textX3
            // 
            this.textX3.Location = new System.Drawing.Point(35, 95);
            this.textX3.Name = "textX3";
            this.textX3.Size = new System.Drawing.Size(70, 20);
            this.textX3.TabIndex = 20;
            this.textX3.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "X4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Y4";
            // 
            // textY4
            // 
            this.textY4.Location = new System.Drawing.Point(137, 121);
            this.textY4.Name = "textY4";
            this.textY4.Size = new System.Drawing.Size(70, 20);
            this.textY4.TabIndex = 25;
            this.textY4.Text = "0";
            // 
            // textX4
            // 
            this.textX4.Location = new System.Drawing.Point(35, 121);
            this.textX4.Name = "textX4";
            this.textX4.Size = new System.Drawing.Size(70, 20);
            this.textX4.TabIndex = 24;
            this.textX4.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "X8";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(111, 225);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Y8";
            // 
            // textY8
            // 
            this.textY8.Location = new System.Drawing.Point(137, 225);
            this.textY8.Name = "textY8";
            this.textY8.Size = new System.Drawing.Size(70, 20);
            this.textY8.TabIndex = 41;
            this.textY8.Text = "0";
            // 
            // textX8
            // 
            this.textX8.Location = new System.Drawing.Point(35, 225);
            this.textX8.Name = "textX8";
            this.textX8.Size = new System.Drawing.Size(70, 20);
            this.textX8.TabIndex = 40;
            this.textX8.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "X7";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(111, 199);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Y7";
            // 
            // textY7
            // 
            this.textY7.Location = new System.Drawing.Point(137, 199);
            this.textY7.Name = "textY7";
            this.textY7.Size = new System.Drawing.Size(70, 20);
            this.textY7.TabIndex = 37;
            this.textY7.Text = "0";
            // 
            // textX7
            // 
            this.textX7.Location = new System.Drawing.Point(35, 199);
            this.textX7.Name = "textX7";
            this.textX7.Size = new System.Drawing.Size(70, 20);
            this.textX7.TabIndex = 36;
            this.textX7.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "X6";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(111, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Y6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(111, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Y5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "X5";
            // 
            // textY6
            // 
            this.textY6.Location = new System.Drawing.Point(137, 173);
            this.textY6.Name = "textY6";
            this.textY6.Size = new System.Drawing.Size(70, 20);
            this.textY6.TabIndex = 31;
            this.textY6.Text = "0";
            // 
            // textX6
            // 
            this.textX6.Location = new System.Drawing.Point(35, 173);
            this.textX6.Name = "textX6";
            this.textX6.Size = new System.Drawing.Size(70, 20);
            this.textX6.TabIndex = 30;
            this.textX6.Text = "0";
            // 
            // textY5
            // 
            this.textY5.Location = new System.Drawing.Point(137, 147);
            this.textY5.Name = "textY5";
            this.textY5.Size = new System.Drawing.Size(70, 20);
            this.textY5.TabIndex = 29;
            this.textY5.Text = "0";
            // 
            // textX5
            // 
            this.textX5.Location = new System.Drawing.Point(35, 147);
            this.textX5.Name = "textX5";
            this.textX5.Size = new System.Drawing.Size(70, 20);
            this.textX5.TabIndex = 28;
            this.textX5.Text = "0";
            // 
            // btnLib
            // 
            this.btnLib.Location = new System.Drawing.Point(44, 463);
            this.btnLib.Name = "btnLib";
            this.btnLib.Size = new System.Drawing.Size(149, 36);
            this.btnLib.TabIndex = 45;
            this.btnLib.Text = "Загрузить библиотеку";
            this.btnLib.UseVisualStyleBackColor = true;
            this.btnLib.Click += new System.EventHandler(this.btnLib_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 511);
            this.Controls.Add(this.btnLib);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textY8);
            this.Controls.Add(this.textX8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textY7);
            this.Controls.Add(this.textX7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textY6);
            this.Controls.Add(this.textX6);
            this.Controls.Add(this.textY5);
            this.Controls.Add(this.textX5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textY4);
            this.Controls.Add(this.textX4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textY3);
            this.Controls.Add(this.textX3);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnPage);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textY2);
            this.Controls.Add(this.textX2);
            this.Controls.Add(this.textY1);
            this.Controls.Add(this.textX1);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.picture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox textX1;
        private System.Windows.Forms.TextBox textY1;
        private System.Windows.Forms.TextBox textX2;
        private System.Windows.Forms.TextBox textY2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnPage;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textY3;
        private System.Windows.Forms.TextBox textX3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textY4;
        private System.Windows.Forms.TextBox textX4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textY8;
        private System.Windows.Forms.TextBox textX8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textY7;
        private System.Windows.Forms.TextBox textX7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textY6;
        private System.Windows.Forms.TextBox textX6;
        private System.Windows.Forms.TextBox textY5;
        private System.Windows.Forms.TextBox textX5;
        private System.Windows.Forms.Button btnLib;
    }
}

