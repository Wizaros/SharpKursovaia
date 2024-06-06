using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Kursovaia_dll;

namespace Kursovaia
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rez = Class1.Vopros8(comboBox1);
            if (!(rez == -1))
            {
                Form13 f13 = new Form13();
                this.Hide();
                f13.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.mass[7] = "Неверно";
            Form13 f13 = new Form13();
            this.Hide();
            f13.ShowDialog();
        }
    }
}
