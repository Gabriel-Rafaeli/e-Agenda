using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromissoArquivo : RepositorioArquivoBase<Compromisso>, IRepositorioCompromisso
    {
        public RepositorioCompromissoArquivo(List<Compromisso> compromissos)
        {
            NOME_ARQUIVO = "C:\\Users\\JV\\Desktop\\Gabriel\\Projetos\\e-Agenda-2023-master\\Arquivos\\compromisso-bin";
            listaRegistros = compromissos;

            if (File.Exists(NOME_ARQUIVO))
                CarregarRegistrosDoArquivo();
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
