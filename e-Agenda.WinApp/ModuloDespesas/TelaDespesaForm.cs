using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace e_Agenda.WinApp.ModuloDespesas
{
    public partial class TelaDespesaForm : Form
    {
        public TelaDespesaForm(List<Categoria> categorias)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            ConfigurarFormaPagamento();
            ConfigurarListaCategorias(categorias);
        }

        private Despesa despesa = null!;

        public Despesa Despesa
        {
            get => despesa;

            set
            {
                txtId.Text = value.id.ToString();
                txtDescricao.Text = value.Descricao;
                txtValor.Text = value.Valor.ToString();
                txtData.Value = value.Data;

                for (int i = 0; i < chListCategorias.Items.Count; i++)
                {
                    for (int j = 0; j < value.CategoriasDaDespesa.Count; j++)
                    {
                        if (chListCategorias.Items[i].Equals(value.CategoriasDaDespesa[j]))
                        {
                            chListCategorias.SetItemChecked(i, true);
                        }
                    }
                }

                foreach (var item in cmbFormaPagamento.Items)
                {
                    if (value.TipoPagamento.ToString() == item.ToString())
                    {
                        cmbFormaPagamento.SelectedItem = item;
                    }
                }
            }
        }

        public void ConfigurarFormaPagamento()
        {
            FormaPagamentoEnum[] formaPagamentos = Enum.GetValues<FormaPagamentoEnum>();

            foreach (FormaPagamentoEnum formaPagamento in formaPagamentos)
            {
                cmbFormaPagamento.Items.Add(formaPagamento);
            }
        }

        public void ConfigurarTela(Despesa despesaSelecionada)
        {
            txtId.Text = despesaSelecionada.id.ToString();
            txtDescricao.Text = despesaSelecionada.Descricao;
            txtValor.Text = despesaSelecionada.Valor.ToString();
            txtData.Value = despesaSelecionada.Data;
            cmbFormaPagamento.SelectedItem = despesaSelecionada.TipoPagamento;
        }

        public void ConfigurarListaCategorias(List<Categoria> categorias)
        {
            chListCategorias.Items.Clear();

            chListCategorias.Items.AddRange(categorias.ToArray());
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string idStr = txtId.Text;
            string descricao = txtDescricao.Text;
            decimal valor = Convert.ToDecimal(txtValor.Text);
            DateTime data = Convert.ToDateTime(txtData.Text);

            string formaPgtoStr = Convert.ToString(cmbFormaPagamento.SelectedItem);
            FormaPagamentoEnum formaPgto;
            bool formaPgtoValida = Enum.TryParse(formaPgtoStr, out formaPgto);

            List<Categoria> categorias = chListCategorias.CheckedItems.Cast<Categoria>().ToList();

            despesa = new Despesa(descricao, valor, data, formaPgto);
            despesa.CategoriasDaDespesa = categorias;

            int id = 0;
            if (!string.IsNullOrEmpty(idStr))
            {
                id = Convert.ToInt32(idStr);
            }
            despesa.id = id;

            List<string> erros = despesa.Validar().ToList();

            if (erros.Any())
            {
                DialogResult = DialogResult.None;

                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
            }
        }
    }
}
