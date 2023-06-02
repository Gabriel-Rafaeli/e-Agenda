using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloDespesas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefaArquivo : RepositorioArquivoBase<Tarefa>, IRepositorioTarefa
    {
        public RepositorioTarefaArquivo(ContextoDados contexto) : base(contexto)
        {
            
        }

        public List<Tarefa> SelecionarConcluidas()
        {
            return ObterRegistros()
                    .Where(x => x.percentualConcluido == 100)
                    .ToList();
        }

        public List<Tarefa> SelecionarPendentes()
        {
            return ObterRegistros()
                    .Where(x => x.percentualConcluido < 100)
                    .ToList();
        }

        public List<Tarefa> SelecionarTodosOrdenadosPorPrioridade()
        {
            return ObterRegistros()
                    .OrderByDescending(x => x.prioridade)
                    .ToList();
        }

        protected override List<Tarefa> ObterRegistros()
        {
            return contextoDados.tarefas;
        }
    }
}
