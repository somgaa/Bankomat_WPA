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
    public partial class DepositOther : Form
    {
        public DepositOther()
        {
            InitializeComponent();
        }

        private void DepositOther_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

                txtAmount.Text += "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {

                txtAmount.Text += "2";

        }

        private void btn7_Click(object sender, EventArgs e)
        {

                txtAmount.Text += "7";

        }

        private void btn9_Click(object sender, EventArgs e)
        {

                txtAmount.Text += "9";

        }

        private void btn8_Click(object sender, EventArgs e)
        {


                txtAmount.Text += "8";

        }

        private void btn0_Click(object sender, EventArgs e)
        {

                txtAmount.Text += "0";

        }

        private void btn6_Click(object sender, EventArgs e)
        {

                txtAmount.Text += "6";

        }

        private void btn5_Click(object sender, EventArgs e)
        {

                txtAmount.Text += "5";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
                txtAmount.Text += "4";

        }

        private void btn3_Click(object sender, EventArgs e)
        {

                txtAmount.Text += "3";

        }


        private void btnYes_Click(object sender, EventArgs e)
        {
            decimal amount;

            if (decimal.TryParse(txtAmount.Text, out amount))
            {
                if (amount > 0 && amount <= 10000)
                {
                    StartATM.balance += amount;
                    StartATM.SaveData();

                    StartATM.AddHistory("Внасяне: +" + amount + " EUR");

                    MessageBox.Show("Успешно внесохте " + amount + " EUR!");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Сумата трябва да е между 1 и 10000 EUR!");
                }
            }
            else
            {
                MessageBox.Show("Моля, въведете валидна сума!");
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            if (txtAmount.Text.Length > 0)
            {
                txtAmount.Text = txtAmount.Text.Substring(0, txtAmount.Text.Length - 1);
            }
        }
    }
}
