using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloDespesas
{
    public class RepositorioDespesaArquivo : RepositorioArquivoBase<Despesa>, IRepositorioDespesa
    {
        public RepositorioDespesaArquivo(ContextoDados contexto) : base(contexto)
        {
            
        }

        public List<Despesa> ListarDespesasPorCategorias(Categoria categoria)
        {
            return ObterRegistros().Where(d => d.CategoriasDaDespesa.Contains(categoria)).ToList();
        }

        protected override List<Despesa> ObterRegistros()
        {
            return contextoDados.despesas;
        }


    }
}
