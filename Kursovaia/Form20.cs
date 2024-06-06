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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Вы не ввели ответ на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (checkedListBox1.CheckedItems.Count == 3)
                {
                    checkedListBox1.Items.Clear();
                    MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Class1.n += 1;
                    Class1.mass[15] = "Верно";
                }
                else
                {
                    MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkedListBox1.Items.Clear();
                    Class1.mass[15] = "Неверно";
                    Class1.n += 0;
                }
                Form21 f21 = new Form21();
                this.Hide();
                f21.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.mass[15] = "Неверно";
            Class1.n += 0;
            Form21 f21 = new Form21();
            this.Hide();
            f21.ShowDialog();
        }
    }
}