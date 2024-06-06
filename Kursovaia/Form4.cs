using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaia
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            this.Hide();
            f.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string fileName = "Glava1.htm";
            string path = Path.GetFullPath(fileName);
            Uri GuideURI = new Uri(String.Format("file:///{0}", path));
            webBrowser1.Navigate(GuideURI);
        }
    }
}
