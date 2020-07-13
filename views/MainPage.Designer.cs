namespace folha_de_ponto.views
{
    partial class MainPage
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helloUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.panelTimesheet = new System.Windows.Forms.Panel();
            this.groupPoint = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPointTime = new System.Windows.Forms.Label();
            this.comboBoxPointType = new System.Windows.Forms.ComboBox();
            this.labelFolhaPonto = new System.Windows.Forms.Label();
            this.timesheetTable = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTimesheet.SuspendLayout();
            this.groupPoint.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(948, 35);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // windowsMenu
            // 
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(68, 29);
            this.windowsMenu.Text = "Login";
            // 
            // helpMenu
            // 
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(118, 29);
            this.helpMenu.Text = "Bater ponto";
            // 
            // helloUser
            // 
            this.helloUser.Name = "helloUser";
            this.helloUser.Size = new System.Drawing.Size(56, 25);
            this.helloUser.Text = "Login";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloUser});
            this.statusStrip.Location = new System.Drawing.Point(0, 667);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(948, 30);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Controls.Add(this.login);
            this.panelLogin.Controls.Add(this.password);
            this.panelLogin.Controls.Add(this.user);
            this.panelLogin.Controls.Add(this.labelSenha);
            this.panelLogin.Controls.Add(this.labelUsuario);
            this.panelLogin.Location = new System.Drawing.Point(0, 39);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(948, 624);
            this.panelLogin.TabIndex = 4;
            this.panelLogin.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(212, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(516, 343);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(96, 40);
            this.login.TabIndex = 10;
            this.login.Text = "Entrar";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(552, 258);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(139, 28);
            this.password.TabIndex = 9;
            this.password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.password_KeyUp);
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(552, 194);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(139, 28);
            this.user.TabIndex = 8;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(448, 262);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(70, 25);
            this.labelSenha.TabIndex = 7;
            this.labelSenha.Text = "Senha";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(448, 197);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(79, 25);
            this.labelUsuario.TabIndex = 6;
            this.labelUsuario.Text = "Usuário";
            // 
            // panelTimesheet
            // 
            this.panelTimesheet.Controls.Add(this.groupPoint);
            this.panelTimesheet.Controls.Add(this.labelFolhaPonto);
            this.panelTimesheet.Controls.Add(this.timesheetTable);
            this.panelTimesheet.Location = new System.Drawing.Point(0, 38);
            this.panelTimesheet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTimesheet.Name = "panelTimesheet";
            this.panelTimesheet.Size = new System.Drawing.Size(948, 624);
            this.panelTimesheet.TabIndex = 6;
            this.panelTimesheet.Visible = false;
            // 
            // groupPoint
            // 
            this.groupPoint.Controls.Add(this.button1);
            this.groupPoint.Controls.Add(this.labelPointTime);
            this.groupPoint.Controls.Add(this.comboBoxPointType);
            this.groupPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPoint.Location = new System.Drawing.Point(72, 75);
            this.groupPoint.Name = "groupPoint";
            this.groupPoint.Size = new System.Drawing.Size(410, 330);
            this.groupPoint.TabIndex = 3;
            this.groupPoint.TabStop = false;
            this.groupPoint.Text = "Bater ponto";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(148, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bater";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // labelPointTime
            // 
            this.labelPointTime.AutoSize = true;
            this.labelPointTime.Location = new System.Drawing.Point(31, 61);
            this.labelPointTime.Name = "labelPointTime";
            this.labelPointTime.Size = new System.Drawing.Size(55, 25);
            this.labelPointTime.TabIndex = 1;
            this.labelPointTime.Text = "Tipo";
            // 
            // comboBoxPointType
            // 
            this.comboBoxPointType.FormattingEnabled = true;
            this.comboBoxPointType.Items.AddRange(new object[] {
            "Início de expediente",
            "Fim de expediente",
            "Início de almoço",
            "Fim de almoço",
            "Início de pause",
            "Fim de pausa"});
            this.comboBoxPointType.Location = new System.Drawing.Point(36, 99);
            this.comboBoxPointType.Name = "comboBoxPointType";
            this.comboBoxPointType.Size = new System.Drawing.Size(337, 33);
            this.comboBoxPointType.TabIndex = 0;
            // 
            // labelFolhaPonto
            // 
            this.labelFolhaPonto.AutoSize = true;
            this.labelFolhaPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFolhaPonto.Location = new System.Drawing.Point(620, 75);
            this.labelFolhaPonto.Name = "labelFolhaPonto";
            this.labelFolhaPonto.Size = new System.Drawing.Size(262, 29);
            this.labelFolhaPonto.TabIndex = 2;
            this.labelFolhaPonto.Text = "Folha de ponto de hoje";
            // 
            // timesheetTable
            // 
            this.timesheetTable.ColumnCount = 2;
            this.timesheetTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.timesheetTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.timesheetTable.Location = new System.Drawing.Point(650, 136);
            this.timesheetTable.Name = "timesheetTable";
            this.timesheetTable.RowCount = 4;
            this.timesheetTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.timesheetTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.timesheetTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.timesheetTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.timesheetTable.Size = new System.Drawing.Size(200, 100);
            this.timesheetTable.TabIndex = 1;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 697);
            this.Controls.Add(this.panelTimesheet);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainPage";
            this.Text = "Folha de ponto";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTimesheet.ResumeLayout(false);
            this.panelTimesheet.PerformLayout();
            this.groupPoint.ResumeLayout(false);
            this.groupPoint.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripStatusLabel helloUser;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Panel panelTimesheet;
        private System.Windows.Forms.GroupBox groupPoint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPointTime;
        private System.Windows.Forms.ComboBox comboBoxPointType;
        private System.Windows.Forms.Label labelFolhaPonto;
        private System.Windows.Forms.TableLayoutPanel timesheetTable;
    }
}



