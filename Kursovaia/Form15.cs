using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursovaia_dll;

namespace Kursovaia
{
    public partial class Form15 : Form
    {

        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int trackBarValue = trackBar1.Value;
            if (trackBar1.Value == 0)
            {
                MessageBox.Show("Вы не ответили на вопрос", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (trackBarValue == 4)
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Class1.n += 1;
                Class1.mass[10] = "Верно";
            }
            else
            {
                MessageBox.Show("Вы ответиили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Class1.mass[10] = "Неверно";
            }
            Form16 f16 = new Form16();
            this.Hide();
            f16.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.mass[10] = "Неверно";
            Form16 f16 = new Form16();
            this.Hide();
            f16.ShowDialog();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar1.Value.ToString();
            trackBar1.Minimum = 1;
        }
    }
}
