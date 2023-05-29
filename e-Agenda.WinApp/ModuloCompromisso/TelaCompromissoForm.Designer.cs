namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class TelaCompromissoForm
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
            label1 = new Label();
            txtId = new TextBox();
            txtAssunto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtData = new DateTimePicker();
            txtHorarioInicio = new DateTimePicker();
            label4 = new Label();
            txtHorarioFinal = new DateTimePicker();
            label5 = new Label();
            cmbContatos = new ComboBox();
            label6 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            rdbOnline = new RadioButton();
            rdbPresencial = new RadioButton();
            txtLocalOnline = new TextBox();
            txtLocalPresencial = new TextBox();
            groupBox1 = new GroupBox();
            chkSelecionarContato = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 21);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(83, 18);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(72, 23);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(83, 47);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(339, 23);
            txtAssunto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 50);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Assunto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 84);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 4;
            label3.Text = "Data:";
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(83, 81);
            txtData.Name = "txtData";
            txtData.Size = new Size(124, 23);
            txtData.TabIndex = 5;
            // 
            // txtHorarioInicio
            // 
            txtHorarioInicio.CustomFormat = "HH:mm";
            txtHorarioInicio.Format = DateTimePickerFormat.Custom;
            txtHorarioInicio.Location = new Point(83, 117);
            txtHorarioInicio.Name = "txtHorarioInicio";
            txtHorarioInicio.ShowUpDown = true;
            txtHorarioInicio.Size = new Size(124, 23);
            txtHorarioInicio.TabIndex = 7;
            // 
            // label4
            // 
            label4.Location = new Point(18, 106);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(53, 37);
            label4.TabIndex = 6;
            label4.Text = "Horário Início:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtHorarioFinal
            // 
            txtHorarioFinal.CustomFormat = "HH:mm";
            txtHorarioFinal.Format = DateTimePickerFormat.Custom;
            txtHorarioFinal.Location = new Point(278, 117);
            txtHorarioFinal.Name = "txtHorarioFinal";
            txtHorarioFinal.ShowUpDown = true;
            txtHorarioFinal.Size = new Size(137, 23);
            txtHorarioFinal.TabIndex = 9;
            // 
            // label5
            // 
            label5.Location = new Point(209, 113);
            label5.Name = "label5";
            label5.Size = new Size(63, 34);
            label5.TabIndex = 8;
            label5.Text = "Horário Final:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbContatos
            // 
            cmbContatos.DisplayMember = "nome";
            cmbContatos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbContatos.Enabled = false;
            cmbContatos.FormattingEnabled = true;
            cmbContatos.Location = new Point(278, 160);
            cmbContatos.Name = "cmbContatos";
            cmbContatos.Size = new Size(137, 23);
            cmbContatos.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(219, 163);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 11;
            label6.Text = "Contato:";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(259, 346);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 40);
            btnGravar.TabIndex = 17;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(340, 346);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 40);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // rdbOnline
            // 
            rdbOnline.AutoSize = true;
            rdbOnline.Location = new Point(28, 58);
            rdbOnline.Name = "rdbOnline";
            rdbOnline.Size = new Size(60, 19);
            rdbOnline.TabIndex = 25;
            rdbOnline.TabStop = true;
            rdbOnline.Text = "Online";
            rdbOnline.UseVisualStyleBackColor = true;
            rdbOnline.CheckedChanged += rdbOnline_CheckedChanged;
            // 
            // rdbPresencial
            // 
            rdbPresencial.AutoSize = true;
            rdbPresencial.Location = new Point(10, 27);
            rdbPresencial.Name = "rdbPresencial";
            rdbPresencial.Size = new Size(78, 19);
            rdbPresencial.TabIndex = 24;
            rdbPresencial.TabStop = true;
            rdbPresencial.Text = "Presencial";
            rdbPresencial.UseVisualStyleBackColor = true;
            rdbPresencial.CheckedChanged += rdbPresencial_CheckedChanged;
            // 
            // txtLocalOnline
            // 
            txtLocalOnline.Location = new Point(94, 58);
            txtLocalOnline.Name = "txtLocalOnline";
            txtLocalOnline.Size = new Size(286, 23);
            txtLocalOnline.TabIndex = 23;
            // 
            // txtLocalPresencial
            // 
            txtLocalPresencial.Location = new Point(94, 26);
            txtLocalPresencial.Name = "txtLocalPresencial";
            txtLocalPresencial.Size = new Size(286, 23);
            txtLocalPresencial.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbOnline);
            groupBox1.Controls.Add(rdbPresencial);
            groupBox1.Controls.Add(txtLocalOnline);
            groupBox1.Controls.Add(txtLocalPresencial);
            groupBox1.Location = new Point(29, 198);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 99);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Local";
            // 
            // chkSelecionarContato
            // 
            chkSelecionarContato.AutoSize = true;
            chkSelecionarContato.Location = new Point(18, 163);
            chkSelecionarContato.Name = "chkSelecionarContato";
            chkSelecionarContato.RightToLeft = RightToLeft.Yes;
            chkSelecionarContato.Size = new Size(188, 19);
            chkSelecionarContato.TabIndex = 22;
            chkSelecionarContato.Text = "?Deseja selecionar um Contato";
            chkSelecionarContato.UseVisualStyleBackColor = true;
            chkSelecionarContato.CheckedChanged += chkSelecionarContato_CheckedChanged;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 417);
            Controls.Add(chkSelecionarContato);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(label6);
            Controls.Add(cmbContatos);
            Controls.Add(txtHorarioFinal);
            Controls.Add(label5);
            Controls.Add(txtHorarioInicio);
            Controls.Add(label4);
            Controls.Add(txtData);
            Controls.Add(label3);
            Controls.Add(txtAssunto);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);           
            Name = "TelaCompromissoForm";          
            Text = "Cadastro de Compromissos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtAssunto;
        private Label label2;
        private Label label3;
        private DateTimePicker txtData;
        private DateTimePicker txtHorarioInicio;
        private Label label4;
        private DateTimePicker txtHorarioFinal;
        private Label label5;
        private ComboBox cmbContatos;
        private Label label6;
        private Button btnGravar;
        private Button btnCancelar;
        private RadioButton rdbOnline;
        private RadioButton rdbPresencial;
        private TextBox txtLocalOnline;
        private TextBox txtLocalPresencial;
        private GroupBox groupBox1;
        private CheckBox chkSelecionarContato;
    }
}