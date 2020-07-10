namespace folha_de_ponto
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTimesheet = new System.Windows.Forms.Panel();
            this.timesheetTable = new System.Windows.Forms.TableLayoutPanel();
            this.labelFolhaPonto = new System.Windows.Forms.Label();
            this.groupPoint = new System.Windows.Forms.GroupBox();
            this.comboBoxPointType = new System.Windows.Forms.ComboBox();
            this.labelPointTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTimesheet.SuspendLayout();
            this.groupPoint.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTimesheet
            // 
            this.panelTimesheet.Controls.Add(this.groupPoint);
            this.panelTimesheet.Controls.Add(this.labelFolhaPonto);
            this.panelTimesheet.Controls.Add(this.timesheetTable);
            this.panelTimesheet.Location = new System.Drawing.Point(63, 53);
            this.panelTimesheet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTimesheet.Name = "panelTimesheet";
            this.panelTimesheet.Size = new System.Drawing.Size(948, 618);
            this.panelTimesheet.TabIndex = 5;
            this.panelTimesheet.Visible = false;
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
            // labelPointTime
            // 
            this.labelPointTime.AutoSize = true;
            this.labelPointTime.Location = new System.Drawing.Point(31, 61);
            this.labelPointTime.Name = "labelPointTime";
            this.labelPointTime.Size = new System.Drawing.Size(55, 25);
            this.labelPointTime.TabIndex = 1;
            this.labelPointTime.Text = "Tipo";
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
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 724);
            this.Controls.Add(this.panelTimesheet);
            this.Name = "HomePage";
            this.Text = "Folha de ponto";
            this.panelTimesheet.ResumeLayout(false);
            this.panelTimesheet.PerformLayout();
            this.groupPoint.ResumeLayout(false);
            this.groupPoint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTimesheet;
        private System.Windows.Forms.Label labelFolhaPonto;
        private System.Windows.Forms.TableLayoutPanel timesheetTable;
        private System.Windows.Forms.GroupBox groupPoint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPointTime;
        private System.Windows.Forms.ComboBox comboBoxPointType;
    }
}