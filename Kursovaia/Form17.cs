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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hScrollBar1.Value == 0)
            {
                MessageBox.Show("Вы не ввели ответ на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (hScrollBar1.Value == 3)
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Class1.n += 1;
                Class1.mass[12] = "Верно";
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Class1.mass[12] = "Неверно";
            }
            Form18 f18 = new Form18();
            this.Hide();
            f18.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.mass[12] = "Неверно";
            Form18 f18 = new Form18();
            this.Hide();
            f18.ShowDialog();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
        }
    }
}
