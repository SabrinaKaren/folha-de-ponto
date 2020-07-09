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

namespace folha_de_ponto.views
{
    public partial class MainPage : Form
    {
        private int childFormNumber = 0;
        private String token = "";

        public MainPage()
        {
            InitializeComponent();
            if (token.Equals(""))
            {
                panelLogin.Visible = true;
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
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
                    //MessageBox.Show("Você logou", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //HomePage homePage = new HomePage();
                    //homePage.Show();
                    token = "asasas";
                    panelLogin.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha inválidos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
