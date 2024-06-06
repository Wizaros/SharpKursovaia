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
using Microsoft.Office.Interop.Excel;
using Application = System.Windows.Forms.Application;
using Axis = Microsoft.Office.Interop.Excel.Axis;
using System.Reflection;

namespace Kursovaia
{
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label1.Text = "Поздравляем, вы прошли тест. Ваш результат: " + Class1.n.ToString() + " из " + Class1.mass.Length.ToString();
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            button1.Visible = false;
            button3.Visible = true;
            for (int i = 0; i < 16; i++)
            {
                dataGridView1.Rows.Add((i + 1).ToString(), Class1.mass[i]);
            }
            string[] sortedArr = (string[])Class1.mass.Clone();
            Class1.BinaryInsertSort(sortedArr);
            for (int i = 0; i < 16; i++)
            {
                dataGridView2.Rows.Add((i + 1).ToString(), sortedArr[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            button3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = true;
            object t = Missing.Value;
            var Book = excelApp.Workbooks.Add(t);
            var Lists = Book.Worksheets;
            Worksheet List = Lists.Item[1];
            List.Cells[1, 1] = "Результаты тестирования";
            List.Range["A2", t].Value2 = "Вопрос 1";
            List.Range["A3", t].Value2 = "Вопрос 2";
            List.Range["A4", t].Value2 = "Вопрос 3";
            List.Range["A5", t].Value2 = "Вопрос 4";
            List.Range["A6", t].Value2 = "Вопрос 5";
            List.Range["A7", t].Value2 = "Вопрос 6";
            List.Range["A8", t].Value2 = "Вопрос 7";
            List.Range["A9", t].Value2 = "Вопрос 8";
            List.Range["A10", t].Value2 = "Вопрос 9";
            List.Range["A11", t].Value2 = "Вопрос 10";
            List.Range["A12", t].Value2 = "Вопрос 11";
            List.Range["A13", t].Value2 = "Вопрос 12";
            List.Range["A14", t].Value2 = "Вопрос 13";
            List.Range["A15", t].Value2 = "Вопрос 14";
            List.Range["A16", t].Value2 = "Вопрос 15";
            List.Range["A17", t].Value2 = "Вопрос 16";
            List.Range["B1", t].Value2 = "Ответ";
            for (int i = 0; i < 16; i++)
            {
                string value = dataGridView1.Rows[i].Cells[1].Value.ToString();
                double number = 0;
                if (value.Equals("Верно", StringComparison.OrdinalIgnoreCase))
                {
                    number = 1;
                }
                List.Range["B" + (i + 2)].Value2 = number;
            }
            Microsoft.Office.Interop.Excel.Chart Diagr = excelApp.Charts.Add(t, t, t, t);
            Diagr.SetSourceData(List.Range["A2", "B17"], Microsoft.Office.Interop.Excel.XlRowCol.xlColumns);
            Diagr.ChartType = XlChartType.xlColumnClustered;
            Diagr.HasLegend = false;
            Diagr.HasTitle = true;
            Diagr.ChartTitle.Caption = "РЕЗУЛЬТАТЫ ТЕСТА";
            Axis Goriz_0s = Diagr.Axes(Microsoft.Office.Interop.Excel.XlAxisType.xlCategory, Microsoft.Office.Interop.Excel.XlAxisGroup.xlPrimary);
            Goriz_0s.HasTitle = true;
            Goriz_0s.AxisTitle.Text = "ОТВЕТЫ";
            Axis Vertic_0s = Diagr.Axes(Microsoft.Office.Interop.Excel.XlAxisType.xlValue, Microsoft.Office.Interop.Excel.XlAxisGroup.xlPrimary);
            Vertic_0s.HasTitle = true;
            Vertic_0s.AxisTitle.Text = "ВОПРОСЫ";
            excelApp.ActiveChart.Export(@"C:\Users\Дмитрий\source\repos\Kursovaia\Kursovaia\bin\Debug\Excel.jpg", t, t);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog otkr = new OpenFileDialog();
            otkr.DefaultExt = "*.xlsm;*.xlsx";
            otkr.Filter = "Microsoft Excel (*xlsm*) |*.xls*";
            otkr.Title = "Выберите документ Excel";
            if (otkr.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Вы не выбрали файл", "Открыть", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            System.Diagnostics.Process.Start(otkr.FileName);
        }
    }
}
