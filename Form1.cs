using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String login_user = LoginTextBox.Text;
            String pass_user = PasswordTextBox.Text;

            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP",db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login_user;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = pass_user;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("You Login Seccesful");
                this.Hide();

                command = new MySqlCommand("SELECT `money` FROM `users` WHERE `login` = @uL", db.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login_user;
                adapter.SelectCommand = command;
                adapter.Fill(table);

                MainPage mp = new MainPage();
                mp.setLogin(login_user);
                decimal balance = Convert.ToDecimal(table.Rows[0]["money"]);
                mp.setBalance(balance);
                mp.Show();
            }

            else
            {
                MessageBox.Show("Wrong password or login");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
