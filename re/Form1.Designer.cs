namespace re
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.RadioButton();
            this.P = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nomer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.one2 = new System.Windows.Forms.Label();
            this.two2 = new System.Windows.Forms.Label();
            this.three2 = new System.Windows.Forms.Label();
            this.one = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.four = new System.Windows.Forms.TextBox();
            this.four2 = new System.Windows.Forms.Label();
            this.three = new System.Windows.Forms.TextBox();
            this.two = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(279, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(317, 368);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ввести данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Location = new System.Drawing.Point(18, 154);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(72, 17);
            this.S.TabIndex = 2;
            this.S.Text = "Площадь";
            this.S.UseVisualStyleBackColor = true;
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.Location = new System.Drawing.Point(128, 154);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(76, 17);
            this.P.TabIndex = 3;
            this.P.Text = "Периметр";
            this.P.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "1) Прямоугольник";
            // 
            // nomer
            // 
            this.nomer.Location = new System.Drawing.Point(96, 116);
            this.nomer.Name = "nomer";
            this.nomer.Size = new System.Drawing.Size(37, 20);
            this.nomer.TabIndex = 5;
            this.nomer.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nomer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.S);
            this.groupBox1.Controls.Add(this.P);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 186);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор фигуры";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Выбор фигуры:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "6) Трапеция";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "5) Параллелограмм";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "4) Квадрат";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "3) Треугольник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "2) Круг";
            // 
            // one2
            // 
            this.one2.AutoSize = true;
            this.one2.Location = new System.Drawing.Point(6, 32);
            this.one2.Name = "one2";
            this.one2.Size = new System.Drawing.Size(68, 13);
            this.one2.TabIndex = 11;
            this.one2.Text = "Сторона A =";
            // 
            // two2
            // 
            this.two2.AutoSize = true;
            this.two2.Location = new System.Drawing.Point(6, 61);
            this.two2.Name = "two2";
            this.two2.Size = new System.Drawing.Size(68, 13);
            this.two2.TabIndex = 12;
            this.two2.Text = "Сторона B =";
            // 
            // three2
            // 
            this.three2.AutoSize = true;
            this.three2.Location = new System.Drawing.Point(6, 89);
            this.three2.Name = "three2";
            this.three2.Size = new System.Drawing.Size(68, 13);
            this.three2.TabIndex = 13;
            this.three2.Text = "Сторона C =";
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(111, 29);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(75, 20);
            this.one.TabIndex = 11;
            this.one.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.four);
            this.groupBox2.Controls.Add(this.four2);
            this.groupBox2.Controls.Add(this.three);
            this.groupBox2.Controls.Add(this.two);
            this.groupBox2.Controls.Add(this.one);
            this.groupBox2.Controls.Add(this.one2);
            this.groupBox2.Controls.Add(this.three2);
            this.groupBox2.Controls.Add(this.two2);
            this.groupBox2.Location = new System.Drawing.Point(13, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 149);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод значений";
            this.groupBox2.Visible = false;
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(111, 112);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(75, 20);
            this.four.TabIndex = 17;
            this.four.Text = "0";
            // 
            // four2
            // 
            this.four2.AutoSize = true;
            this.four2.Location = new System.Drawing.Point(6, 115);
            this.four2.Name = "four2";
            this.four2.Size = new System.Drawing.Size(68, 13);
            this.four2.TabIndex = 16;
            this.four2.Text = "Сторона C =";
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(111, 86);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(75, 20);
            this.three.TabIndex = 15;
            this.three.Text = "0";
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(111, 58);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(75, 20);
            this.two.TabIndex = 14;
            this.two.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Вычислить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(393, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Очистить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 422);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Нахождение S и P фигур";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton S;
        private System.Windows.Forms.RadioButton P;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label one2;
        private System.Windows.Forms.Label two2;
        private System.Windows.Forms.Label three2;
        private System.Windows.Forms.TextBox one;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox three;
        private System.Windows.Forms.TextBox two;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox four;
        private System.Windows.Forms.Label four2;
    }
}

