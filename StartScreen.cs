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
using System.IO;

namespace Bankomat_WPA
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            txtEnterPIN.PasswordChar = '*';
            txtEnterPIN.MaxLength = 4;

            StartATM.LoadData();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtEnterPIN.Text.Length < 4)
            {
                txtEnterPIN.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtEnterPIN.Text.Length < 4)
            {
                txtEnterPIN.Text += "2";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtEnterPIN.Text.Length < 4)
            {
                txtEnterPIN.Text += "7";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtEnterPIN.Text.Length < 4)
            {
                txtEnterPIN.Text += "9";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtEnterPIN.Text.Length < 4)
            {
                txtEnterPIN.Text += "8";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtEnterPIN.Text.Length < 4)
            {
                txtEnterPIN.Text += "0";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtEnterPIN.Text.Length < 4)
            {
                txtEnterPIN.Text += "6";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtEnterPIN.Text.Length < 4)
            {
                txtEnterPIN.Text += "5";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtEnterPIN.Text.Length < 4)
            {
                txtEnterPIN.Text += "4";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtEnterPIN.Text.Length < 4)
            {
                txtEnterPIN.Text += "3";
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtEnterPIN.Clear();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtEnterPIN.Text == StartATM.pin)
            {
                StartATM menu = new StartATM();
                menu.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Грешен ПИН код!");
                txtEnterPIN.Clear();
            }
        }
        public void ResetPIN()
        {
            txtEnterPIN.Clear();
        }
    }
}
