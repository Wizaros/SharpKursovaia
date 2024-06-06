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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.AutoCheck = false;
            radioButton2.AutoCheck = false;
            radioButton3.AutoCheck = false;
            radioButton4.AutoCheck = false;
            radioButton5.AutoCheck = false;
            radioButton6.AutoCheck = false;
            int rez = Class1.Vopros7(radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6);
            if (!(rez == -1))
            {
                Form12 f12 = new Form12();
                this.Hide();
                f12.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.mass[6] = "Неверно";
            Form12 f12 = new Form12();
            this.Hide();
            f12.Show();
        }
    }
}
