using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloContato
{
    public class RepositorioContatoArquivo : RepositorioArquivoBase<Contato>, IRepositorioContato
    {
        public RepositorioContatoArquivo(List<Contato> contatos)
        {
            NOME_ARQUIVO = "C:\\Users\\JV\\Desktop\\Gabriel\\Projetos\\e-Agenda-2023-master\\Arquivos\\contato-bin";

            listaRegistros = contatos;

            if (File.Exists(NOME_ARQUIVO))
                CarregarRegistrosDoArquivo();
        }
    }
}
