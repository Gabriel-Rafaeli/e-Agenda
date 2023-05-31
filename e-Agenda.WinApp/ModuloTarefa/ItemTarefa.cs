namespace e_Agenda.WinApp.ModuloTarefa
{
    [Serializable]
    public class ItemTarefa
    {
        public string titulo;
        public bool concluido;

        public ItemTarefa(string titulo)
        {
            this.titulo = titulo;
        }

        public override string ToString()
        {
            return titulo;
        }

        public void Concluir()
        {
            concluido = true;
        }

        public override bool Equals(object? obj)
        {
            return obj is ItemTarefa tarefa &&
                   titulo == tarefa.titulo &&
                   concluido == tarefa.concluido;
        }

        public void Desmarcar()
        {
            concluido = false;
        }
    }
}
