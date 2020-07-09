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
using timesheet.database;

namespace folha_de_ponto
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {

            EmployeeBLL employeeRepository = new EmployeeBLL();

            if (user.Text == "" || password.Text == "")
            {
                MessageBox.Show("O usuario e a senha devem ser informados.");
            }
            else
            {

                EmployeeDTO newEmployee = new EmployeeDTO();
                newEmployee.setUser(user.Text);
                newEmployee.setPassword(password.Text);

                DataTable loginReturn = employeeRepository.loginUser(newEmployee);

                if (loginReturn.Select().Length > 0)
                {
                    MessageBox.Show("Você logou!");
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha inválidos.");
                }

            }

        }

        private void password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_Click(sender, e);
            }
        }
    }
}
