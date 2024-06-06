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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rez = Class1.Vopros1("Процессный", "процессный", textBox1.Text);
            if (!(rez == -1))
            {
                Form6 f6 = new Form6();
                this.Hide();
                f6.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.mass[0] = "Неверно";
            Form6 f6 = new Form6();
            this.Hide();
            f6.Show();
        }
    }
}
