using e_Agenda.WinApp.ModuloDespesas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class TelaVisualizarCategoriaForm : Form
    {
        public TelaVisualizarCategoriaForm(List<Despesa> lista)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            AtualizarLista(lista);
        }

        private void AtualizarLista(List<Despesa> lista)
        {
            listDespesasDaCategoria.Items.Clear();

            foreach (Despesa despesa in lista) 
            {
                listDespesasDaCategoria.Items.Add(despesa);
            }
        }
    }
}
