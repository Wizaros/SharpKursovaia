using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Kursovaia_dll;

namespace Kursovaia
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.AutoCheck = false;
            radioButton2.AutoCheck = false;
            radioButton3.AutoCheck = false;
            int rez = Class1.Vopros5(radioButton1, radioButton2, radioButton3);
            if (!(rez == -1))
            {
                Form10 f10 = new Form10();
                this.Hide();
                f10.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.mass[4] = "Неверно";
            Form10 f10 = new Form10();
            this.Hide();
            f10.Show();
        }
    }
}
