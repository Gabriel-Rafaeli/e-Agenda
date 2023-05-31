using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloContato
{
    public class RepositorioContatoMemoria : RepositorioMemoriaBase<Contato>, IRepositorioContato
    {
        public RepositorioContatoMemoria(List<Contato> contatos)
        {
            this.listaRegistros = contatos;
        }
    }
}
