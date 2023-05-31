using e_Agenda.WinApp.ModuloContato;
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
        public RepositorioTarefaArquivo(List<Tarefa> tarefas)
        {
            NOME_ARQUIVO = "C:\\Users\\JV\\Desktop\\Gabriel\\Projetos\\e-Agenda-2023-master\\Arquivos\\tarefa-bin";

            listaRegistros = tarefas;

            if (File.Exists(NOME_ARQUIVO))
                CarregarRegistrosDoArquivo();
        }

        public List<Tarefa> SelecionarConcluidas()
        {
            return listaRegistros
                    .Where(x => x.percentualConcluido == 100)
                    .ToList();
        }

        public List<Tarefa> SelecionarPendentes()
        {
            return listaRegistros
                    .Where(x => x.percentualConcluido < 100)
                    .ToList();
        }

        public List<Tarefa> SelecionarTodosOrdenadosPorPrioridade()
        {
            return listaRegistros
                    .OrderByDescending(x => x.prioridade)
                    .ToList();
        }
    }
}
