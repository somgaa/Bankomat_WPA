
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
    public partial class CheckBalance : Form
    {
        public CheckBalance()
        {
            InitializeComponent();

            lblBalance.Text = StartATM.balance.ToString("F2") + " €";
        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
