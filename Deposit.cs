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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            this.Hide();

            DepositOther form = new DepositOther();
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

        private void btnTwenty_Click(object sender, EventArgs e)
        {
            DepositMoney(20);
        }

        private void btnFifty_Click(object sender, EventArgs e)
        {
            DepositMoney(50);
        }

        private void btnFiveHundred_Click(object sender, EventArgs e)
        {
            DepositMoney(500);
        }

        private void btnTwoHundred_Click(object sender, EventArgs e)
        {
            DepositMoney(200);
        }

        private void btnHundred_Click(object sender, EventArgs e)
        {
            DepositMoney(100);
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            DepositMoney(10);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDepositMenu_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void DepositMoney(decimal amount)
        {
            StartATM.balance += amount;
            StartATM.SaveData();
            StartATM.AddHistory("Внасяне: +" + amount + " EUR");

            MessageBox.Show("Успешно внесохте " + amount + " EUR!");

            this.Close();
        }
    }
}
