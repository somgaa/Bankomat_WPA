
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
    public partial class LatestOperations : Form
    {
        int currentPage = 0;
        int perPage = 5;

        public LatestOperations()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Clear();
            listView1.Columns.Add("Операция", 260);
            listView1.Columns.Add("Дата", 170);
            listView1.Columns.Add("Час", 140);
            listView1.Columns.Add("Сума", 150);

            ShowHistory();
        }

        private void ShowHistory()
        {
            listView1.Items.Clear();

            int total = StartATM.history.Count;
            int totalPages = (total + perPage - 1) / perPage;

            if (totalPages == 0)
            {
                totalPages = 1;
            }

            lblPage.Text = (currentPage + 1) + " / " + totalPages;

            for (int i = currentPage * perPage; i < (currentPage + 1) * perPage; i++)
            {
                int index = total - 1 - i;

                if (index < 0)
                {
                    break;
                }

                string[] data = StartATM.history[index].Split('|');

                string operation = data[0];
                string date = "-";
                string time = "-";

                if (data.Length >= 3)
                {
                    date = data[1];
                    time = data[2];
                }

                string name = operation;
                string amount = "-";

                int pos = operation.IndexOf(':');

                if (pos >= 0)
                {
                    name = operation.Substring(0, pos);
                    amount = operation.Substring(pos + 1).Trim();

                    if (amount.Contains(" към "))
                    {
                        amount = amount.Substring(0, amount.IndexOf(" към "));
                    }
                }

                ListViewItem item = new ListViewItem(name);

                item.SubItems.Add(date);
                item.SubItems.Add(time);
                item.SubItems.Add(amount);

                if (amount.StartsWith("+"))
                {
                    item.ForeColor = Color.Green;
                }
                else if (amount.StartsWith("-"))
                {
                    item.ForeColor = Color.DarkRed;
                }

                listView1.Items.Add(item);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if ((currentPage + 1) * perPage < StartATM.history.Count)
            {
                currentPage++;
                ShowHistory();
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                ShowHistory();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblPage_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
