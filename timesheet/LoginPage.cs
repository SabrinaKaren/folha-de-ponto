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
using timesheet.database;
using timesheet.database.selectCollections;

namespace timesheet
{
    public partial class LoginPage : Form
    {

        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            EmployeeBLL employeeRepository = new EmployeeBLL();

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("O usuario e a senha devem ser informados.");
            } else
            {

                EmployeeDTO newEmployee = new EmployeeDTO();
                newEmployee.setUser(textBox1.Text);
                newEmployee.setPassword(textBox2.Text);

                DataTable loginReturn = employeeRepository.loginUser(newEmployee);
                DataRow[] rows = loginReturn.Select();

                if (loginReturn.Select().Length > 0)
                {
                    MessageBox.Show("Você logou!");
                } else
                {
                    MessageBox.Show("Usuário e/ou senha inválidos.");
                }                

            }

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, null);
            }
        }
    }
}
