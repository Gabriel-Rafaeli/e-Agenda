namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaCadastroItensTarefaForm : Form
    {
        public TelaCadastroItensTarefaForm(Tarefa tarefa)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            ConfigurarTela(tarefa);
        }

        private void ConfigurarTela(Tarefa tarefa)
        {
            txtId.Text = tarefa.id.ToString();

            txtTitulo.Text = tarefa.titulo;

            listItens.Items.AddRange(tarefa.items.ToArray());
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloItem.Text;

            ItemTarefa itemTarefa = new ItemTarefa(titulo);

            listItens.Items.Add(itemTarefa);
        }

        public List<ItemTarefa> ObterItensCadastrados()
        {
            return listItens.Items.Cast<ItemTarefa>().ToList();
        }
    }
}
