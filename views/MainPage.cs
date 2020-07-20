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
using folha_de_ponto.code.data;
using folha_de_ponto.code.utils;
using folha_de_ponto.code.bll;
using folha_de_ponto.code.dto;

namespace folha_de_ponto.views
{
    public partial class MainPage : Form
    {

        private int childFormNumber = 0;
        private String token = "";
        private DateTime tokenValidate;
        private int employeeId = 0;

        EmployeeBLL employeeRepository = new EmployeeBLL();
        TokenBLL tokenRepository = new TokenBLL();
        CommonMethods commonMethods = new CommonMethods();
        TimesheetBLL timesheetRepository = new TimesheetBLL();

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

            if (user.Text == "" || password.Text == "")
            {
                MessageBox.Show("O usuario e a senha devem ser informados.");
            }
            else
            {

                EmployeeDTO newEmployee = new EmployeeDTO();
                newEmployee.setUser(user.Text);
                newEmployee.setPassword(password.Text);

                DataTable employeeLogged = employeeRepository.loginUser(newEmployee);

                if (employeeLogged.Select().Length > 0)
                {
                    // mensagem amigável com nome de usuário
                    helloUser.Text = "Olá, " + employeeLogged.Rows[0].ItemArray[1].ToString();

                    employeeId = Convert.ToInt32(employeeLogged.Rows[0].ItemArray[0].ToString());
                    TokenWithValidateData tokenObject = tokenRepository.generateToken(employeeId);

                    // settando o token e a validade
                    token = tokenObject.getToken();
                    tokenValidate = tokenObject.getValidate();

                    // retirando o painel de login da tela
                    panelLogin.Visible = false;

                    // habilitando o próximo painel (de ponto)
                    panelTimesheet.Visible = true;
                    this.panelTimesheetController();

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

        private void panelTimesheetController()
        {

            // colocando os itens dentro do combo-box
            this.buildComboBoxPointType();

            // carregar tabela de pontos já realizados hoje
            this.buildTimesheetTable();

        }

        private void buildTimesheetTable()
        {

            if (!commonMethods.tokenIsValidate(token, tokenValidate))
            {
                panelTimesheet.Visible = false;
                panelLogin.Visible = true;                
            } else
            {
                timesheetTable.DataSource = timesheetRepository.getEmployeeTimesheetOfTodayByToken(token);
            }

        }

        private void buildComboBoxPointType()
        {
            comboBoxPointType.Items.Insert(0, "Início de expediente");
            comboBoxPointType.Items.Insert(1, "Fim de expediente");
            comboBoxPointType.Items.Insert(2, "Início de almoço");
            comboBoxPointType.Items.Insert(3, "Fim de almoço");
            comboBoxPointType.Items.Insert(4, "Início de pausa");
            comboBoxPointType.Items.Insert(5, "Fim de pausa");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBoxPointType.SelectedItem == null)
            {
                MessageBox.Show("É necessário, primeiro, selecionar um tipo.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {

                int timesheetTypeId = comboBoxPointType.SelectedIndex + 1;

                TimesheetDTO newTimesheet = new TimesheetDTO();
                newTimesheet.setTimesheetEmployeeId(employeeId);
                newTimesheet.setDateTime(DateTime.Now);
                newTimesheet.setTimesheetTypeId(timesheetTypeId);

                timesheetRepository.setPoint(newTimesheet);
                this.buildTimesheetTable();

            }

        }
    }
}
