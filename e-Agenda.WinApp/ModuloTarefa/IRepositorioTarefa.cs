using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public interface IRepositorioTarefa : IRepositorio<Tarefa>
    {
        public List<Tarefa>? SelecionarConcluidas();

        public List<Tarefa>? SelecionarPendentes();

        public List<Tarefa> SelecionarTodosOrdenadosPorPrioridade();
    }
}
