namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class TelaFiltroCompromissoForm
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
            btnFiltrar = new Button();
            btnCancelar = new Button();
            rbdTodos = new RadioButton();
            rbdPassados = new RadioButton();
            rdbFuturos = new RadioButton();
            txtDataInicio = new DateTimePicker();
            txtDataFinal = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnFiltrar
            // 
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Location = new Point(156, 298);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 50);
            btnFiltrar.TabIndex = 0;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(237, 298);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 50);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // rbdTodos
            // 
            rbdTodos.AutoSize = true;
            rbdTodos.Location = new Point(34, 31);
            rbdTodos.Name = "rbdTodos";
            rbdTodos.Size = new Size(206, 19);
            rbdTodos.TabIndex = 2;
            rbdTodos.TabStop = true;
            rbdTodos.Text = "Visualizar Todos os Compromissos";
            rbdTodos.UseVisualStyleBackColor = true;
            // 
            // rbdPassados
            // 
            rbdPassados.AutoSize = true;
            rbdPassados.Location = new Point(34, 68);
            rbdPassados.Name = "rbdPassados";
            rbdPassados.Size = new Size(208, 19);
            rbdPassados.TabIndex = 3;
            rbdPassados.TabStop = true;
            rbdPassados.Text = "Visualizar Compromissos Passados";
            rbdPassados.UseVisualStyleBackColor = true;
            // 
            // rdbFuturos
            // 
            rdbFuturos.AutoSize = true;
            rdbFuturos.Location = new Point(34, 106);
            rdbFuturos.Name = "rdbFuturos";
            rdbFuturos.Size = new Size(200, 19);
            rdbFuturos.TabIndex = 4;
            rdbFuturos.TabStop = true;
            rdbFuturos.Text = "Visualizar Compromissos Futuros";
            rdbFuturos.UseVisualStyleBackColor = true;
            rdbFuturos.CheckedChanged += rdbFuturos_CheckedChanged;
            // 
            // txtDataInicio
            // 
            txtDataInicio.Enabled = false;
            txtDataInicio.Format = DateTimePickerFormat.Short;
            txtDataInicio.Location = new Point(91, 164);
            txtDataInicio.Name = "txtDataInicio";
            txtDataInicio.Size = new Size(149, 23);
            txtDataInicio.TabIndex = 5;
            // 
            // txtDataFinal
            // 
            txtDataFinal.Enabled = false;
            txtDataFinal.Format = DateTimePickerFormat.Short;
            txtDataFinal.Location = new Point(91, 202);
            txtDataFinal.Name = "txtDataFinal";
            txtDataFinal.Size = new Size(151, 23);
            txtDataFinal.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 170);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 7;
            label1.Text = "Data Inicial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 208);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 8;
            label2.Text = "Data Final:";
            // 
            // TelaFiltroCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 369);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDataFinal);
            Controls.Add(txtDataInicio);
            Controls.Add(rdbFuturos);
            Controls.Add(rbdPassados);
            Controls.Add(rbdTodos);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroCompromissoForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtro de Compromissos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFiltrar;
        private Button btnCancelar;
        private RadioButton rbdTodos;
        private RadioButton rbdPassados;
        private RadioButton rdbFuturos;
        private DateTimePicker txtDataInicio;
        private DateTimePicker txtDataFinal;
        private Label label1;
        private Label label2;
    }
}