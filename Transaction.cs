
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
    public partial class Transaction : Form
    {
        bool letterMode = false;
        int letterPage = 0;
        int currentBox = 1;

        public Transaction()
        {
            InitializeComponent();

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;

            textBox1.MaxLength = 22;
            textBox2.MaxLength = 10;
            textBox3.MaxLength = 50;

            textBox1.Text = "BG";

            UpdateButtons();
        }

        private void UpdateButtons()
        {
            if (currentBox == 2)
            {
                letterMode = false;
                btnLetterMode.Text = "✔";
            }
            else if (letterMode == false)
            {
                btnLetterMode.Text = "ABC";
            }
            else
            {
                btnLetterMode.Text = "123";
            }

            if (letterMode == false)
            {
                btn1.Text = "1";
                btn2.Text = "2";
                btn3.Text = "3";
                btn4.Text = "4";
                btn5.Text = "5";
                btn6.Text = "6";
                btn7.Text = "7";
                btn8.Text = "8";
                btn9.Text = "9";
                btn0.Text = "0";
            }
            else
            {
                string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                Button[] buttons = {
                    btn1, btn2, btn3,
                    btn4, btn5, btn6,
                    btn7, btn8, btn9
                };

                for (int i = 0; i < 9; i++)
                {
                    int index = letterPage * 9 + i;

                    if (index < letters.Length)
                    {
                        buttons[i].Text = letters[index].ToString();
                        buttons[i].Enabled = true;
                    }
                    else
                    {
                        buttons[i].Text = "-";
                        buttons[i].Enabled = false;
                    }
                }

                btn0.Text = "→";
            }

            if (letterMode == false)
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
            }
        }

        private void EnterKey(string value)
        {
            if (currentBox == 1)
            {
                if (textBox1.Text.Length < 22)
                {
                    textBox1.Text += value;
                }

                if (textBox1.Text.Length == 22)
                {
                    currentBox = 2;
                    letterMode = false;
                    UpdateButtons();
                    textBox2.Focus();
                }
            }
            else if (currentBox == 2)
            {
                if (textBox2.Text.Length < 10)
                {
                    textBox2.Text += value;
                }
            }
            else if (currentBox == 3)
            {
                if (textBox3.Text.Length < 50)
                {
                    textBox3.Text += value;
                }
            }
        }

        private void btnLetterMode_Click(object sender, EventArgs e)
        {
            if (currentBox == 2)
            {
                decimal amount;

                if (decimal.TryParse(textBox2.Text, out amount) && amount > 0)
                {
                    currentBox = 3;
                    letterMode = false;
                    letterPage = 0;

                    UpdateButtons();
                    textBox3.Focus();
                }
                else
                {
                    MessageBox.Show("Въведете валидна сума!");
                }
            }
            else
            {
                letterMode = !letterMode;
                letterPage = 0;

                UpdateButtons();
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (letterMode == true)
            {
                letterPage++;

                if (letterPage > 2)
                {
                    letterPage = 0;
                }

                UpdateButtons();
            }
            else
            {
                EnterKey("0");
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            EnterKey(btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            EnterKey(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            EnterKey(btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            EnterKey(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            EnterKey(btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            EnterKey(btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            EnterKey(btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            EnterKey(btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            EnterKey(btn9.Text);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            TextBox box = textBox1;

            if (currentBox == 2)
            {
                box = textBox2;
            }
            else if (currentBox == 3)
            {
                box = textBox3;
            }

            if (box.Text.Length > 0)
            {
                if (currentBox == 1 && box.Text.Length <= 2)
                {
                    return;
                }

                box.Text = box.Text.Substring(0, box.Text.Length - 1);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            currentBox = 1;
            UpdateButtons();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            currentBox = 2;
            UpdateButtons();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            currentBox = 3;
            letterMode = false;
            UpdateButtons();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            decimal amount;
            string iban = textBox1.Text.ToUpper();

            if (iban.Length != 22 || !iban.StartsWith("BG"))
            {
                MessageBox.Show("Невалиден IBAN!");
            }
            else if (!decimal.TryParse(textBox2.Text, out amount))
            {
                MessageBox.Show("Въведете валидна сума!");
            }
            else if (amount <= 0 || amount > StartATM.balance)
            {
                MessageBox.Show("Невалидна сума или недостатъчна наличност!");
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "IBAN: " + iban +
                    "\nСума: " + amount + " EUR" +
                    "\nОснование: " + textBox3.Text +
                    "\n\nПотвърждавате ли превода?",
                    "Потвърждение",
                    MessageBoxButtons.YesNo
                );

                if (result == DialogResult.Yes)
                {
                    StartATM.balance -= amount;
                    StartATM.SaveData();

                    StartATM.AddHistory("Превод: -" + amount + " EUR към " + iban);

                    MessageBox.Show("Преводът е успешен!");
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {

        }

        private void lblMainMenu_Click(object sender, EventArgs e)
        {

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
