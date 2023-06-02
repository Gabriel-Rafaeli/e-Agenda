using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloContato
{
    public class RepositorioContatoArquivo : RepositorioArquivoBase<Contato>, IRepositorioContato
    {
        public RepositorioContatoArquivo(ContextoDados contexto) : base(contexto)
        {
            
        }

        protected override List<Contato> ObterRegistros()
        {
            return contextoDados.contatos;
        }
    }
}
