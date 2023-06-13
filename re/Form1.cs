using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace re
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            button2.Visible = true;

            if (S.Checked == false && P.Checked == false)
            {
                groupBox2.Visible = false;
                button2.Visible = false;
                MessageBox.Show("Выберите площади или периметр");
            }

            if (S.Checked)
            {
                switch (Convert.ToInt32(nomer.Text))
                {
                    case 1:
                        one2.Text = "Сторона A =";
                        two2.Text = "Сторона B =";
                        one2.Visible = true;
                        one.Visible = true;
                        two2.Visible = true;
                        two.Visible = true;
                        three2.Visible = false;
                        three.Visible = false;
                        four2.Visible = false;
                        four.Visible = false;
                        break;

                    case 2:
                        one2.Text = "Радиус =";
                        one2.Visible = true;
                        one.Visible = true;
                        two2.Visible = false;
                        two.Visible = false;
                        three2.Visible = false;
                        three.Visible = false;
                        four2.Visible = false;
                        four.Visible = false;
                        break;

                    case 3:
                        one2.Text = "Сторона А =";
                        two2.Text = "Сторона B =";
                        three2.Text = "Сторона С =";
                        one2.Visible = true;
                        one.Visible = true;
                        two2.Visible = true;
                        two.Visible = true;
                        three2.Visible = true;
                        three.Visible = true;
                        four2.Visible = false;
                        four.Visible = false;
                        break;

                    case 4:
                        one2.Text = "Сторона А =";
                        one2.Visible = true;
                        one.Visible = true;
                        two2.Visible = false;
                        two.Visible = false;
                        three2.Visible = false;
                        three.Visible = false;
                        four2.Visible = false;
                        four.Visible = false;
                        break;

                    case 5:
                        one2.Text = "Сторона А =";
                        two2.Text = "Высота =";
                        one2.Visible = true;
                        one.Visible = true;
                        two2.Visible = true;
                        two.Visible = true;
                        three2.Visible = false;
                        three.Visible = false;
                        four2.Visible = false;
                        four.Visible = false;
                        break;

                    case 6:
                        one2.Text = "Основание А =";
                        two2.Text = "Основание B =";
                        three2.Text = "Высота =";
                        one2.Visible = true;
                        one.Visible = true;
                        two2.Visible = true;
                        two.Visible = true;
                        three2.Visible = true;
                        three.Visible = true;
                        four2.Visible = false;
                        four.Visible = false;
                        break;

                    default:
                        groupBox2.Visible = false;
                        button2.Visible = false;
                        MessageBox.Show("Фигуры с таким номер нет");
                        break;

                }
            }

            if (P.Checked)
            {
                switch (Convert.ToInt32(nomer.Text))
                {
                    case 1:
                        one2.Text = "Сторона А =";
                        two2.Text = "Сторона B =";
                        one2.Visible = true;
                        one.Visible = true;
                        two2.Visible = true;
                        two.Visible = true;
                        three2.Visible = false;
                        three.Visible = false;
                        four2.Visible = false;
                        four.Visible = false;
                        break;

                    case 2:
                        one2.Text = "Радиус =";
                        one2.Visible = true;
                        one.Visible = true;
                        two2.Visible = false;
                        two.Visible = false;
                        three2.Visible = false;
                        three.Visible = false;
                        four2.Visible = false;
                        four.Visible = false;
                        break;

                    case 3:
                        one2.Text = "Сторона А =";
                        two2.Text = "Сторона B =";
                        three2.Text = "Сторона С =";
                        one2.Visible = true;
                        one.Visible = true;
                        two2.Visible = true;
                        two.Visible = true;
                        three2.Visible = true;
                        three.Visible = true;
                        four2.Visible = false;
                        four.Visible = false;
                        break;

                    case 4:
                        one2.Text = "Сторона А =";
                        one2.Visible = true;
                        one.Visible = true;
                        two2.Visible = false;
                        two.Visible = false;
                        three2.Visible = false;
                        three.Visible = false;
                        four2.Visible = false;
                        four.Visible = false;
                        break;

                    case 5:
                        one2.Text = "Ширина =";
                        two2.Text = "Высота =";
                        one2.Visible = true;
                        one.Visible = true;
                        two2.Visible = true;
                        two.Visible = true;
                        three2.Visible = false;
                        three.Visible = false;
                        four2.Visible = false;
                        four.Visible = false;
                        break;

                    case 6:
                        one2.Text = "Сторона А =";
                        two2.Text = "Сторона B =";
                        three2.Text = "Сторона С =";
                        four2.Text = "Сторона D =";
                        one2.Visible = true;
                        one.Visible = true;
                        two2.Visible = true;
                        two.Visible = true;
                        three2.Visible = true;
                        three.Visible = true;
                        four2.Visible = true;
                        four.Visible = true;
                        break;

                    default:
                        groupBox2.Visible = false;
                        button2.Visible = false;
                        MessageBox.Show("Фигуры с таким номер нет");
                        break;

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (S.Checked)
            {
                switch (Convert.ToInt32(nomer.Text))
                {
                    case 1:
                        listBox1.Items.Add("S Прямоуголника = " + Convert.ToDouble(one.Text) * Convert.ToDouble(two.Text));
                        break;
                    case 2:
                        listBox1.Items.Add("S Круга = " + Math.PI * Math.Pow(Convert.ToDouble(one.Text), 2));
                        break;

                    case 3:
                        double p = (Convert.ToDouble(one.Text) + Convert.ToDouble(two.Text) + Convert.ToDouble(three.Text)) / 2;
                        listBox1.Items.Add("S Треугольника = " + Math.Sqrt(p * (p - Convert.ToDouble(one.Text)) * (p - Convert.ToDouble(two.Text)) * (p - Convert.ToDouble(three.Text))) );
                        break;

                    case 4:
                        listBox1.Items.Add("S Квадрата = " + Math.Pow(Convert.ToDouble(one.Text), 2));
                        break;

                    case 5:
                        listBox1.Items.Add("S Параллелограмма = " + Convert.ToDouble(one.Text) * Convert.ToDouble(two.Text));
                        break;

                    case 6:
                        listBox1.Items.Add("S Трапеции = " + (Convert.ToDouble(one.Text) + Convert.ToDouble(two.Text)) * Convert.ToDouble(three.Text) / 2);
                        break;
                }
            }

            if (P.Checked)
            {
                switch (Convert.ToInt32(nomer.Text))
                {
                    case 1:
                        listBox1.Items.Add("P Прямоуголника = " + (2 * Convert.ToDouble(one.Text) + 2 * Convert.ToDouble(two.Text)));
                        break;
                    case 2:
                        listBox1.Items.Add("P Круга = " + 2 * Math.PI * Convert.ToDouble(one.Text));
                        break;

                    case 3:
                        listBox1.Items.Add("P Треуголника = " + (Convert.ToDouble(one.Text) + Convert.ToDouble(two.Text) + Convert.ToDouble(three.Text)));
                        break;

                    case 4:
                        listBox1.Items.Add("P Квадрат = " + 4 * Convert.ToDouble(one.Text));
                        break;

                    case 5:
                        listBox1.Items.Add("P Параллелограмма = " + 2 * (Convert.ToDouble(one.Text) + Convert.ToDouble(two.Text)));
                        break;

                    case 6:
                        listBox1.Items.Add("P Трапеции = " + (Convert.ToDouble(one.Text) + Convert.ToDouble(two.Text) + Convert.ToDouble(three.Text) + Convert.ToDouble(four.Text)));
                        break;
                }
            }

            groupBox2.Visible = false;
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
