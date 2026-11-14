
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankomat_WPA
{
    public partial class ChangePIN : Form
    {
        int currentBox = 1;

        public ChangePIN()
        {
            InitializeComponent();

            textBox1.PasswordChar = '*';
            textBox2.PasswordChar = '*';
            textBox3.PasswordChar = '*';

            textBox1.MaxLength = 4;
            textBox2.MaxLength = 4;
            textBox3.MaxLength = 4;

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
        }

        private void EnterNumber(string number)
        {
            if (currentBox == 1)
            {
                if (textBox1.Text.Length < 4)
                {
                    textBox1.Text += number;
                }

                if (textBox1.Text.Length == 4)
                {
                    currentBox = 2;
                    textBox2.Focus();
                }
            }
            else if (currentBox == 2)
            {
                if (textBox2.Text.Length < 4)
                {
                    textBox2.Text += number;
                }

                if (textBox2.Text.Length == 4)
                {
                    currentBox = 3;
                    textBox3.Focus();
                }
            }
            else if (currentBox == 3)
            {
                if (textBox3.Text.Length < 4)
                {
                    textBox3.Text += number;
                }
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            EnterNumber("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            EnterNumber("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            EnterNumber("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            EnterNumber("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            EnterNumber("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            EnterNumber("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            EnterNumber("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            EnterNumber("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            EnterNumber("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            EnterNumber("9");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            currentBox = 1;
            textBox1.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != StartATM.pin)
            {
                MessageBox.Show("Грешен стар ПИН код!");
            }
            else if (textBox2.Text.Length != 4)
            {
                MessageBox.Show("Новият ПИН трябва да съдържа 4 цифри!");
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Новите ПИН кодове не съвпадат!");
            }
            else
            {
                StartATM.pin = textBox2.Text;
                StartATM.SaveData();

                StartATM.AddHistory("Смяна на ПИН код");

                MessageBox.Show("ПИН кодът е сменен успешно!");

                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
