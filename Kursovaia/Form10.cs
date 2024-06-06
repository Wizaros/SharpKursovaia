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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rez = Class1.Vopros6(comboBox1, comboBox2, comboBox3, comboBox4);
            if (!(rez == -1))
            {
                Form11 f11 = new Form11();
                this.Hide();
                f11.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.mass[5] = "Неверно";
            Form11 f11 = new Form11();
            this.Hide();
            f11.ShowDialog();
        }
    }
}
