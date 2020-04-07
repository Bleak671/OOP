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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.btnPage = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(221, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(567, 426);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "Line",
            "Ellipse",
            "Rectangle"});
            this.cmb1.Location = new System.Drawing.Point(23, 16);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(184, 21);
            this.cmb1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 133);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(184, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add in List";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(23, 180);
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
            // 
            // textY1
            // 
            this.textY1.Location = new System.Drawing.Point(137, 43);
            this.textY1.Name = "textY1";
            this.textY1.Size = new System.Drawing.Size(70, 20);
            this.textY1.TabIndex = 5;
            // 
            // textX2
            // 
            this.textX2.Location = new System.Drawing.Point(35, 69);
            this.textX2.Name = "textX2";
            this.textX2.Size = new System.Drawing.Size(70, 20);
            this.textX2.TabIndex = 6;
            // 
            // textY2
            // 
            this.textY2.Location = new System.Drawing.Point(137, 69);
            this.textY2.Name = "textY2";
            this.textY2.Size = new System.Drawing.Size(70, 20);
            this.textY2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Y2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "X2";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(35, 230);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(70, 28);
            this.btnList.TabIndex = 12;
            this.btnList.Text = "Clear List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnPage
            // 
            this.btnPage.Location = new System.Drawing.Point(137, 230);
            this.btnPage.Name = "btnPage";
            this.btnPage.Size = new System.Drawing.Size(70, 28);
            this.btnPage.TabIndex = 13;
            this.btnPage.Text = "Clear Page";
            this.btnPage.UseVisualStyleBackColor = true;
            this.btnPage.Click += new System.EventHandler(this.btnPage_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(35, 95);
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
            this.textBox1.Location = new System.Drawing.Point(18, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(121, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(10, 20);
            this.textBox2.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 24);
            this.button1.TabIndex = 17;
            this.button1.Text = "LineColor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnPage);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnPage;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}

