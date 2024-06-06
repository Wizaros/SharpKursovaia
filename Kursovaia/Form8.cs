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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rez = Class1.Vopros4(checkBox1, checkBox2, checkBox3, checkBox4);
            if (!(rez == -1))
            {
                Form9 f9 = new Form9();
                this.Hide();
                f9.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.mass[3] = "Неверно";
            Form9 f9 = new Form9();
            this.Hide();
            f9.Show();
        }
    }
}
