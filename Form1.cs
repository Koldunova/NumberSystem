using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            //из 10
            //2
            if (radioButton1.Checked && radioButton5.Checked)
            {
                int ch = Convert.ToInt32(textBox1.Text);
                dv(ch);
            }
            //8
            if (radioButton3.Checked && radioButton5.Checked)
            {
                int ch = Convert.ToInt32(textBox1.Text);
                vosm(ch);
            }
            //16
            if (radioButton2.Checked && radioButton5.Checked)
            {
                int ch = Convert.ToInt32(textBox1.Text);
                shest(ch);
            }
            //10
            if (radioButton4.Checked && radioButton5.Checked)
            {
                label2.Text = "Результат: " +  textBox1.Text;

            }

            string sh = textBox1.Text;
            double res = 0;
            //из 8
            int st = sh.Length-1;
            //в 10
            if (radioButton7.Checked && radioButton4.Checked)
            { 
                foreach (char el in sh)
                {
                    res += (Convert.ToInt32(el) - 48) * Math.Pow(8, st);
                    st--;
                }
                label2.Text = "Результат: " + res.ToString();
            }
            //в 8
            if (radioButton7.Checked && radioButton3.Checked)
            {
                label2.Text = "Результат: " + textBox1.Text;

            }
            //в 2
            if (radioButton7.Checked && radioButton1.Checked)
            {
                foreach (char el in sh)
                {
                    res += (Convert.ToInt32(el) - 48) * Math.Pow(8, st);
                    st--;
                }
                dv((int)Math.Round(res));

            }
            //в 16
            if (radioButton7.Checked && radioButton2.Checked)
            {
                foreach (char el in sh)
                {
                    res += (Convert.ToInt32(el) - 48) * Math.Pow(8, st);
                    st--;
                }
                shest((int)Math.Round(res));

            }

            // Из 2
            //в 10
            if (radioButton8.Checked && radioButton4.Checked)
            {
                foreach (char el in sh)
                {
                    res += (Convert.ToInt32(el) - 48) * Math.Pow(2, st);
                    st--;
                }
                label2.Text = "Результат: " + res.ToString();
            }
            //в 8
            if (radioButton8.Checked && radioButton3.Checked)
            {
                foreach (char el in sh)
                {
                    res += (Convert.ToInt32(el) - 48) * Math.Pow(2, st);
                    st--;
                }
                vosm((int)Math.Round(res));

            }
            //в 16
            if (radioButton8.Checked && radioButton2.Checked)
            {
                foreach (char el in sh)
                {
                    res += (Convert.ToInt32(el) - 48) * Math.Pow(2, st);
                    st--;
                }
                shest((int)Math.Round(res));

            }
            //в 2
            if (radioButton8.Checked && radioButton1.Checked)
            {
                label2.Text = "Результат: " + textBox1.Text;

            }

            //Из 16
            //в 10
            if (radioButton6.Checked && radioButton4.Checked)
            {
                st = textBox1.Text.Length - 1;
                foreach (char el in sh)
                {
                    switch (el)
                    {
                        case 'A': res += 10 * Math.Pow(16, st); break;
                        case 'B': res += 11 * Math.Pow(16, st); break;
                        case 'C': res += 12 * Math.Pow(16, st); break;
                        case 'D': res += 13 * Math.Pow(16, st); break;
                        case 'E': res += 14 * Math.Pow(16, st); break;
                        case 'F': res += 15 * Math.Pow(16, st); break;
                        default: res += (Convert.ToInt32(el) - 48) * Math.Pow(16, st); break;
                    }
                    st--;
                }
                label2.Text = "Результат: " + res.ToString();
            }
            //в 8
            if (radioButton6.Checked && radioButton3.Checked)
            {
                st = textBox1.Text.Length - 1;
                foreach (char el in sh)
                {
                    switch (el)
                    {
                        case 'A': res += 10 * Math.Pow(16, st); break;
                        case 'B': res += 11 * Math.Pow(16, st); break;
                        case 'C': res += 12 * Math.Pow(16, st); break;
                        case 'D': res += 13 * Math.Pow(16, st); break;
                        case 'E': res += 14 * Math.Pow(16, st); break;
                        case 'F': res += 15 * Math.Pow(16, st); break;
                        default: res += (Convert.ToInt32(el) - 48) * Math.Pow(16, st); break;
                    }
                    st--;
                }
                vosm((int)Math.Round(res));

            }
            //в 2
            if (radioButton6.Checked && radioButton1.Checked)
            {
                st = textBox1.Text.Length-1;
                foreach (char el in sh)
                {
                    switch (el)
                    {
                        case 'A': res += 10 * Math.Pow(16, st); break;
                        case 'B': res += 11 * Math.Pow(16, st); break;
                        case 'C': res += 12 * Math.Pow(16, st); break;
                        case 'D': res += 13 * Math.Pow(16, st); break;
                        case 'E': res += 14 * Math.Pow(16, st); break;
                        case 'F': res += 15 * Math.Pow(16, st); break;
                        default: res += (Convert.ToInt32(el)-48 ) * Math.Pow(16, st); break;
                    }
                    st--;
                }
               
                dv((int)Math.Round(res));

            }
            //в 16
            if (radioButton6.Checked && radioButton2.Checked)
            {
                label2.Text = "Результат: " + textBox1.Text;

            }
        }

        public void dv(int ch)
        {
            string res = "";
            string reverse_res = "";
            int del = 0;
            do
            {
                del = ch / 2;
                int buf = ch - (del * 2);
                res += buf;
                ch = del;
                if (ch == 0 || ch == 1)
                {
                    res += ch;
                    break;
                }
            } while (ch != 0 || ch != 1);
            for (int i = res.Length - 1; i > -1; i--)
            {
                reverse_res += res[i];
            }
            label2.Text = "Результат: " + reverse_res;
        }

        public void vosm(int ch)
        {
            string res = "";
            string reverse_res = "";
            int del = 0;
            do
            {
                del = ch / 8;
                int buf = ch - (del * 8);
                res += buf;
                ch = del;
                Console.WriteLine(del);
                if (ch == 0 || ch == 1)
                {
                    res += ch;
                    break;
                }
            } while (ch != 0 || ch != 1);
            for (int i = res.Length - 1; i > -1; i--)
            {
                reverse_res += res[i];
            }
            label2.Text = "Результат: " + reverse_res;
        }

        public void shest(int ch)
        {
            string res = "";
            string reverse_res = "";
            int del = 0;
            do
            {
                del = ch / 16;
                int buf = ch - (del * 16);
                if (buf > 9)
                {

                    switch (buf)
                    {
                        case 10: res += 'A'; break;
                        case 11: res += 'B'; break;
                        case 12: res += 'C'; break;
                        case 13: res += 'D'; break;
                        case 14: res += 'E'; break;
                        case 15: res += 'F'; break;
                        case 16: res += "10"; break;
                    }

                }
                else
                {
                    res += buf;
                }
                ch = del;
                if (ch == 0 || ch == 1)
                {
                    res += ch;
                    break;
                }
            } while (ch != 0 || ch != 1);
            for (int i = res.Length - 1; i > -1; i--)
            {
                reverse_res += res[i];
            }
            label2.Text = "Результат: " + reverse_res;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
