using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Axis = Microsoft.Office.Interop.Excel.Axis;

namespace Kursovaia_dll
{
    public class Class1
    {
        public static int n = 0;
        public static string[] mass = new string[16];
        public static int Vopros1(string right_ans, string right_ans_2, string ans)
        {
            if (ans == "")
            {
                MessageBox.Show("Вы не ввели ответ на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
                if ((ans == right_ans) || (ans == right_ans_2))
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                n = n + 1;
                mass[0] = "Верно";
                return 1;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mass[0] = "Неверно";
                return 0;
            }
        }
        public static int Vopros2(CheckBox CB1, CheckBox CB2, CheckBox CB3, CheckBox CB4)
        {
            if ((!CB1.Checked) && (!CB2.Checked) && (!CB3.Checked) && (!CB4.Checked))
            {
                MessageBox.Show("Вы не выбрали ни один из вариантов ответа", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
                if ((!CB1.Checked) && (CB2.Checked) && (!CB3.Checked) && (CB4.Checked))
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                n = n + 1;
                mass[1] = "Верно";
                return 1;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mass[1] = "Неверно";
                return 0;
            }
        }
        public static int Vopros3(string right_ans, string right_ans_2, string ans)
        {
            if (ans == "")
            {
                MessageBox.Show("Вы не ввели ответ на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
                if ((ans == right_ans) || (ans == right_ans_2))
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                n = n + 1;
                mass[2] = "Верно";
                return 1;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mass[2] = "Неверно";
                return 0;
            }
        }
        public static int Vopros4(CheckBox CB1, CheckBox CB2, CheckBox CB3, CheckBox CB4)
        {
            if ((!CB1.Checked) && (!CB2.Checked) && (!CB3.Checked) && (!CB4.Checked))
            {
                MessageBox.Show("Вы не выбрали ни один из вариантов ответа", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
                if ((CB1.Checked) && (CB2.Checked) && (!CB3.Checked) && (CB4.Checked))
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                n = n + 1;
                mass[3] = "Верно";
                return 1;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mass[3] = "Неверно";
                return 0;
            }
        }
        public static int Vopros5(RadioButton radioButton1, RadioButton radioButton2, RadioButton radioButton3)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                n = n + 1;
                mass[4] = "Неверно";
                return 0;
                
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                n = n + 1;
                mass[4] = "Верно";
                return 1;
            }
            if (radioButton3.Checked)
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                n = n + 1;
                mass[4] = "Неверно";
                return 0;
            }
            if ((! radioButton1.Checked) && (! radioButton2.Checked) && (! radioButton3.Checked))
            {
                MessageBox.Show("Вы не выбрали ответ на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            return 0;
        }
        public static int Vopros6(ComboBox CB1, ComboBox CB2, ComboBox CB3, ComboBox CB4)
        {
            if ((CB1.SelectedIndex == -1) || (CB2.SelectedIndex == -1) || (CB3.SelectedIndex == -1) || (CB4.SelectedIndex == -1))
            {
                MessageBox.Show("Вы не указали все варианты ответов", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if ((CB1.SelectedIndex == 2) && (CB2.SelectedIndex == 0) && (CB3.SelectedIndex == 1) && (CB4.SelectedIndex == 3))
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                mass[5] = "Верно";
                return 1;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mass[5] = "Неверно";
                return 0;
            }
        }
        public static int Vopros7(RadioButton radioButton1, RadioButton radioButton2, RadioButton radioButton3, RadioButton radioButton4, RadioButton radioButton5, RadioButton radioButton6)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
                radioButton6.Enabled = false;
                n = n + 1;
                mass[6] = "Неверно";
                return 0;

            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
                radioButton6.Enabled = false;
                n = n + 1;
                mass[6] = "Неверно";
                return 0;
            }
            if (radioButton3.Checked)
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
                radioButton6.Enabled = false;
                n = n + 1;
                mass[6] = "Неверно";
                return 0;
            }
            if (radioButton4.Checked)
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
                radioButton6.Enabled = false;
                n = n + 1;
                mass[6] = "Неверно";
                return 0;
            }
            if (radioButton5.Checked)
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
                radioButton6.Enabled = false;
                n = n + 1;
                mass[6] = "Неверно";
                return 0;
            }
            if (radioButton6.Checked)
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
                radioButton6.Enabled = false;
                n = n + 1;
                mass[6] = "Верно";
                return 1;
            }
            if ((!radioButton1.Checked) && (!radioButton2.Checked) && (!radioButton3.Checked) && (!radioButton4.Checked) && (!radioButton5.Checked) && (!radioButton6.Checked))
            {
                MessageBox.Show("Вы не выбрали ответ на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            return 0;
        }
        public static int Vopros8(ComboBox CB1)
        {
            if ((CB1.SelectedIndex == -1))
            {
                MessageBox.Show("Вы не указали все варианты ответов", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if ((CB1.SelectedIndex == 0))
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                mass[7] = "Верно";
                return 1;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mass[7] = "Неверно";
                return 0;
            }
        }
        public static void Vivod_DGV(string x, string y, DataGridView DGV)
        {
            DGV.Rows.Add(x, y);
        }
        public static void BinaryInsertSort(string[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                string value = arr[i];
                int left = 0;
                int right = i - 1;
                int j = i;
                while (left <= right)
                {
                    int m = (left + right) / 2;
                    if (string.Compare(value, arr[m]) < 0)
                    {
                        right = m - 1;
                    }
                    else
                    {
                        left = m + 1;
                    }
                }
                while (j > left)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[left] = value;
            }
        }
    }
}
