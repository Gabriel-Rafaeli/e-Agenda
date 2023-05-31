using e_Agenda.WinApp.ModuloCategoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloDespesas
{
    public class RepositorioDespesaArquivo : RepositorioArquivoBase<Despesa>, IRepositorioDespesa
    {
        public RepositorioDespesaArquivo(List<Despesa> despesas)
        {
            NOME_ARQUIVO = "C:\\Users\\JV\\Desktop\\Gabriel\\Projetos\\e-Agenda-2023-master\\Arquivos\\despesa-bin";

            listaRegistros = despesas;

            if (File.Exists(NOME_ARQUIVO))
                CarregarRegistrosDoArquivo();
        }

        public List<Despesa> ListarDespesasPorCategorias(Categoria categoria)
        {
            return listaRegistros.Where(d => d.CategoriasDaDespesa.Contains(categoria)).ToList();
        }
    }
}
