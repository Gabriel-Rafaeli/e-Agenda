namespace e_Agenda.WinApp.Compartilhado
{
    [Serializable]
    public abstract class EntidadeBase<TEntidade>
    {
        public int id;

        public abstract void AtualizarInformacoes(TEntidade registroAtualizado);

        public abstract string[] Validar();
    }
}
