using e_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.Compartilhado
{
    public interface IRepositorio<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        void Inserir(TEntidade novoRegistro);
        void Editar(int id, TEntidade registro);
        void Excluir(TEntidade registroSelecionado);
        TEntidade SelecionarPorId(int id);
        List<TEntidade> SelecionarTodos();
    }
}
