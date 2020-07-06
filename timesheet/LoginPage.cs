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
using timesheet.database.selectCollections;

namespace timesheet
{
    public partial class LoginPage : Form
    {

        public LoginPage()
        {
            Connection newConnection = new Connection();
            bool connected = newConnection.connectNow();
            if (connected)
            {
                InitializeComponent();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("O usuario e a senha devem ser informados.");
            } else
            {
                EmployeeRepository employeeRepository = new EmployeeRepository();
                string userToken = employeeRepository.authUser(textBox1.Text, textBox2.Text);
                MessageBox.Show("Novo token: " + userToken);
            }

        }
    }
}
