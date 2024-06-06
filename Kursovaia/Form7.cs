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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rez = Class1.Vopros3("Инноваций", "инноваций", textBox1.Text);
            if (!(rez == -1))
            {
                Form8 f8 = new Form8();
                this.Hide();
                f8.Show();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.mass[2] = "Неверно";
            Form8 f8 = new Form8();
            this.Hide();
            f8.Show();
        }
    }
}
