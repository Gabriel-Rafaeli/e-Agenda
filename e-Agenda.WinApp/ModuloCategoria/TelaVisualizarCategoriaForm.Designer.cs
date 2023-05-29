namespace e_Agenda.WinApp.ModuloCategoria
{
    partial class TelaVisualizarCategoriaForm
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
            lblcategoriaSelecionada = new Label();
            groupBox1 = new GroupBox();
            listDespesasDaCategoria = new ListBox();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Categoria:";
            // 
            // lblcategoriaSelecionada
            // 
            lblcategoriaSelecionada.AutoSize = true;
            lblcategoriaSelecionada.Location = new Point(91, 21);
            lblcategoriaSelecionada.Name = "lblcategoriaSelecionada";
            lblcategoriaSelecionada.Size = new Size(42, 15);
            lblcategoriaSelecionada.TabIndex = 1;
            lblcategoriaSelecionada.Text = "-------";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listDespesasDaCategoria);
            groupBox1.Location = new Point(24, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 227);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Despesas";
            // 
            // listDespesasDaCategoria
            // 
            listDespesasDaCategoria.FormattingEnabled = true;
            listDespesasDaCategoria.ItemHeight = 15;
            listDespesasDaCategoria.Location = new Point(0, 22);
            listDespesasDaCategoria.Name = "listDespesasDaCategoria";
            listDespesasDaCategoria.Size = new Size(384, 199);
            listDespesasDaCategoria.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(333, 278);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 40);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Fechar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaVisualizarCategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 330);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(lblcategoriaSelecionada);
            Controls.Add(label1);
            Name = "TelaVisualizarCategoriaForm";
            Text = "TelaVisualizarCategoriaForm";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblcategoriaSelecionada;
        private GroupBox groupBox1;
        private ListBox listDespesasDaCategoria;
        private Button btnCancelar;
    }
}