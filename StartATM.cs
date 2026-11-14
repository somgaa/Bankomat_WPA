using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bankomat_WPA
{
    public partial class StartATM : Form
    {
        public StartATM()
        {
            InitializeComponent();
        }

        public static string pin = "1234";
        public static decimal balance = 1500;

        public static List<string> history = new List<string>();

        static string file = Application.UserAppDataPath + "\\data.txt";
        static string historyFile = Application.UserAppDataPath + "\\history.txt";

        public static void SaveData()
        {
            File.WriteAllLines(file, new string[]
            {
        pin,
        balance.ToString()
            });
        }

        public static void LoadData()
        {
            if (File.Exists(file))
            {
                string[] data = File.ReadAllLines(file);

                if (data.Length >= 2)
                {
                    decimal savedBalance;

                    if (decimal.TryParse(data[1], out savedBalance))
                    {
                        pin = data[0];
                        balance = savedBalance;
                    }
                }
            }

            if (File.Exists(historyFile))
            {
                history = new List<string>(File.ReadAllLines(historyFile));
            }
        }

        public static void AddHistory(string operation)
        {
            string date = DateTime.Now.ToString("dd.MM.yyyy");
            string time = DateTime.Now.ToString("HH:mm");

            history.Add(operation + "|" + date + "|" + time);

            File.WriteAllLines(historyFile, history);
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            this.Hide();

            CheckBalance form = new CheckBalance();
            form.ShowDialog();

            this.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            this.Hide();

            Withdraw form = new Withdraw();
            form.ShowDialog();

            this.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            this.Hide();

            Deposit form = new Deposit();
            form.ShowDialog();

            this.Show();
        }

        private void btnChangePIN_Click(object sender, EventArgs e)
        {
            this.Hide();

            ChangePIN form = new ChangePIN();
            form.ShowDialog();

            this.Show();
        }

        private void btnLatestOperations_Click(object sender, EventArgs e)
        {
            this.Hide();

            LatestOperations form = new LatestOperations();
            form.ShowDialog();

            this.Show();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            this.Hide();

            Transaction form = new Transaction();
            form.ShowDialog();

            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            StartScreen start = (StartScreen)Application.OpenForms["StartScreen"];

            start.ResetPIN();
            start.Show();

            this.Close();
        }

        private void StartATM_Load(object sender, EventArgs e)
        {

        }
    }
}
