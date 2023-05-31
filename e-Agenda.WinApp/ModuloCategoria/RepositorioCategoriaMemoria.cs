using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public class RepositorioCategoriaMemoria : RepositorioMemoriaBase<Categoria>, IRepositorioCategoria
    {
        public RepositorioCategoriaMemoria(List<Categoria> listaCategorias)
        {
            listaRegistros = listaCategorias;
        }
    }
}
