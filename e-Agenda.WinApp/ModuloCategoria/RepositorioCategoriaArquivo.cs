using e_Agenda.WinApp.ModuloCompromisso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public class RepositorioCategoriaArquivo : RepositorioArquivoBase<Categoria>, IRepositorioCategoria
    {        
        public RepositorioCategoriaArquivo(ContextoDados contexto) : base(contexto)
        {
            
        }

        protected override List<Categoria> ObterRegistros()
        {
            return contextoDados.categorias;
        }
    }
}
