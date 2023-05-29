namespace e_Agenda.WinApp.ModuloDespesas
{
    partial class TelaDespesaForm
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
            btnCancelar = new Button();
            btnGravar = new Button();
            label3 = new Label();
            lblDescricao = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtDescricao = new TextBox();
            txtValor = new TextBox();
            txtData = new DateTimePicker();
            cmbFormaPagamento = new ComboBox();
            chListCategorias = new CheckedListBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(299, 320);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(218, 320);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 4;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 62);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 14;
            label3.Text = "Valor:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(12, 37);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 13;
            lblDescricao.Text = "Descrição:";
            lblDescricao.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 12);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 12;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 87);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 15;
            label2.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 112);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 16;
            label4.Text = "Forma Pgto:";
            // 
            // txtId
            // 
            txtId.Location = new Point(79, 9);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(61, 23);
            txtId.TabIndex = 17;
            txtId.Text = "0";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(79, 34);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(289, 23);
            txtDescricao.TabIndex = 19;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(79, 59);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(117, 23);
            txtValor.TabIndex = 20;
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(79, 84);
            txtData.Name = "txtData";
            txtData.Size = new Size(117, 23);
            txtData.TabIndex = 21;
            // 
            // cmbFormaPagamento
            // 
            cmbFormaPagamento.FormattingEnabled = true;
            cmbFormaPagamento.Location = new Point(79, 109);
            cmbFormaPagamento.Name = "cmbFormaPagamento";
            cmbFormaPagamento.Size = new Size(117, 23);
            cmbFormaPagamento.TabIndex = 22;
            // 
            // chListCategorias
            // 
            chListCategorias.FormattingEnabled = true;
            chListCategorias.Location = new Point(6, 22);
            chListCategorias.Name = "chListCategorias";
            chListCategorias.Size = new Size(350, 148);
            chListCategorias.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chListCategorias);
            groupBox1.Location = new Point(12, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(362, 176);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Categorias";
            // 
            // TelaDespesaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 373);
            Controls.Add(groupBox1);
            Controls.Add(cmbFormaPagamento);
            Controls.Add(txtData);
            Controls.Add(txtValor);
            Controls.Add(txtDescricao);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblDescricao);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "TelaDespesaForm";
            Text = "TelaDespesaForm";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private Label label3;
        private Label lblDescricao;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtId;
        private TextBox txtDescricao;
        private TextBox txtValor;
        private DateTimePicker txtData;
        private ComboBox cmbFormaPagamento;
        private CheckedListBox chListCategorias;
        private GroupBox groupBox1;
    }
}