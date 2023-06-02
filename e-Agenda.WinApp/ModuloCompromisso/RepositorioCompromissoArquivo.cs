using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromissoArquivo : RepositorioArquivoBase<Compromisso>, IRepositorioCompromisso
    {
        public RepositorioCompromissoArquivo(ContextoDados contexto) : base(contexto)
        {
            
        }

        public List<Compromisso> SelecionarCompromissosPassados(DateTime hoje)
        {
            return ObterRegistros().Where(x => x.data.Date < hoje.Date).ToList();
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal)
        {
            return ObterRegistros()
                .Where(x => x.data > dataInicio)
                .Where(x => x.data < dataFinal)
                .ToList();
        }

        protected override List<Compromisso> ObterRegistros()
        {
            return contextoDados.compromissos;
        }
    }
}
