using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public interface IRepositorioCompromisso : IRepositorio<Compromisso>
    {
        public List<Compromisso> SelecionarCompromissosPassados(DateTime hoje);

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal);

    }
}
