using Kursovaia_dll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaia
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((listBox2.Text == "") || (listBox3.Text == "") || (listBox4.Text == ""))
            {
                MessageBox.Show("Вы не ответили на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if ((listBox2.Items[0].ToString() == "EDI;") && (listBox3.Items[0].ToString() == "LT;") && (listBox4.Items[0].ToString() == "TQM;"))
                {
                    MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Class1.n += 1;
                    Class1.mass[13] = "Верно";
                }
                else
                {
                    MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Class1.mass[13] = "Неверно";
                }
                Form19 f19 = new Form19();
                this.Hide();
                f19.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.mass[13] = "Неверно";
            Form19 f19 = new Form19();
            this.Hide();
            f19.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 1)
            {
                MessageBox.Show("Один элемент уже выбран");
                return;
            }
            if (listBox1.SelectedIndex == 0)
            {
                listBox2.Items.Add(listBox1.Text);
                listBox2.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(0);
            }
            if (listBox1.SelectedIndex == 1)
            {
                listBox2.Items.Add(listBox1.Text);
                listBox2.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(1);
            }
            if (listBox1.SelectedIndex == 2)
            {
                listBox2.Items.Add(listBox1.Text);
                listBox2.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox3.Items.Count == 1)
            {
                MessageBox.Show("Один элемент уже выбран");
                return;
            }
            if (listBox1.SelectedIndex == 0)
            {
                listBox3.Items.Add(listBox1.Text);
                listBox3.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(0);
            }
            if (listBox1.SelectedIndex == 1)
            {
                listBox3.Items.Add(listBox1.Text);
                listBox3.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(1);
            }
            if (listBox1.SelectedIndex == 2)
            {
                listBox3.Items.Add(listBox1.Text);
                listBox3.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(2);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox4.Items.Count == 1)
            {
                MessageBox.Show("Один элемент уже выбран");
                return;
            }
            if (listBox1.SelectedIndex == 0)
            {
                listBox4.Items.Add(listBox1.Text);
                listBox4.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(0);
            }
            if (listBox1.SelectedIndex == 1)
            {
                listBox4.Items.Add(listBox1.Text);
                listBox4.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(1);
            }
            if (listBox1.SelectedIndex == 2)
            {
                listBox4.Items.Add(listBox1.Text);
                listBox4.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(2);
            }
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            string[] Itemlist1 = new string[3];
            Itemlist1[0] = "EDI;";
            Itemlist1[1] = "LT;";
            Itemlist1[2] = "TQM;";
            for (int j = 0; j <= 2; j++)
            {
                listBox1.Items.Add(Itemlist1[j]);
            }
        }
    }
}