
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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTwoHundred_Click(object sender, EventArgs e)
        {
            WithdrawMoney(200);
        }

        private void btnTwenty_Click(object sender, EventArgs e)
        {
            WithdrawMoney(20);
        }

        private void btnFifty_Click(object sender, EventArgs e)
        {
            WithdrawMoney(50);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            this.Hide();

            WithdrawOther form = new WithdrawOther();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btnFiveHundred_Click(object sender, EventArgs e)
        {
            WithdrawMoney(500);
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            WithdrawMoney(10);
        }

        private void btnHundred_Click(object sender, EventArgs e)
        {
            WithdrawMoney(100);
        }

        private void WithdrawMoney(decimal amount)
        {
            if (amount <= StartATM.balance)
            {
                StartATM.balance -= amount;
                StartATM.SaveData();
                StartATM.AddHistory("Теглене: -" + amount + " EUR");

                MessageBox.Show("Успешно изтеглихте " + amount + " EUR!");

                this.Close();
            }
            else
            {
                MessageBox.Show("Недостатъчна наличност!");
            }
        }
    }
}
