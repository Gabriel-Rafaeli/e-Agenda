namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaAtualizacaoItensTarefaForm : Form
    {
        public TelaAtualizacaoItensTarefaForm(Tarefa tarefa)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            ConfigurarTela(tarefa);
        }

        private void ConfigurarTela(Tarefa tarefa)
        {
            txtId.Text = tarefa.id.ToString();

            txtTitulo.Text = tarefa.titulo;

            int i = 0;
            foreach (ItemTarefa item in tarefa.items)
            {
                listItensTarefa.Items.Add(item);

                if (item.concluido)
                    listItensTarefa.SetItemChecked(i, true);

                i++;
            }
        }

        public List<ItemTarefa> ObterItensMarcados()
        {
            return listItensTarefa.CheckedItems.Cast<ItemTarefa>().ToList();
        }

        public List<ItemTarefa> ObterItensPendentes()
        {
            return listItensTarefa.Items.Cast<ItemTarefa>()
                .Except(ObterItensMarcados())
                .ToList();
        }
    }
}
