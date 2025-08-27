using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_bank
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        String login;
        decimal balance;

        public void setLogin(String l)
        {
            login = l;
        }
        public void setBalance(decimal b)
        {
            balance = b;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            NameLabel.Text = login;
            BalanceLabel.Text = balance.ToString();
        }
    }
}
