using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public class RepositorioCategoriaArquivo : RepositorioArquivoBase<Categoria>, IRepositorioCategoria
    {        
        public RepositorioCategoriaArquivo(List<Categoria> categorias)
        {
            NOME_ARQUIVO = "C:\\Users\\JV\\Desktop\\Gabriel\\Projetos\\e-Agenda-2023-master\\Arquivos\\categoria-bin";
            this.listaRegistros = categorias;

            if (File.Exists(NOME_ARQUIVO))
                CarregarRegistrosDoArquivo();
        }
    }
}
