using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloDespesas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class ListagemDespesaControl : UserControl
    {
        public ListagemDespesaControl()
        {
            InitializeComponent();
        }
        public void AtualizarRegistros(List<Despesa> despesas)
        {
            listDespesa.Items.Clear();

            foreach(Despesa despesa in despesas)
            {
                listDespesa.Items.Add(despesa);
            }
        }

        public Despesa ObterDespesaSelecionada()
        {
            return (Despesa)listDespesa.SelectedItem;
        }
    }
}
