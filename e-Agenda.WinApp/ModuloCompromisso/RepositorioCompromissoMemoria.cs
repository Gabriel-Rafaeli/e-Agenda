using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromissoMemoria : RepositorioMemoriaBase<Compromisso>, IRepositorioCompromisso
    {
        public RepositorioCompromissoMemoria(List<Compromisso> compromissos)
        {
            this.listaRegistros = compromissos;
        }

        public List<Compromisso> SelecionarCompromissosPassados(DateTime hoje)
        {
            return listaRegistros.Where(x => x.data.Date < hoje.Date).ToList();
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal)
        {
            return listaRegistros
                .Where(x => x.data > dataInicio)
                .Where(x => x.data < dataFinal)
                .ToList();
        }


    }
}
