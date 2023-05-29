using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {
        public TelaTarefaForm(bool edicaoDeTarefa)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarPrioridades();

            if (edicaoDeTarefa)
            {
                txtDataCriacao.Enabled = false;
            }
        }

        private void CarregarPrioridades()
        {
            PrioridadeTarefaEnum[] prioridades = Enum.GetValues<PrioridadeTarefaEnum>();

            foreach (PrioridadeTarefaEnum prioridade in prioridades)
            {
                cmbPrioridade.Items.Add(prioridade);
            }
        }

        public Tarefa ObterTarefa()
        {
            int id = Convert.ToInt32(txtId.Text);

            string titulo = txtTitulo.Text;

            PrioridadeTarefaEnum prioridade = (PrioridadeTarefaEnum)cmbPrioridade.SelectedItem;

            DateTime dataCriacao = txtDataCriacao.Value;

            return new Tarefa(id, titulo, prioridade, dataCriacao);
        }

        public void ConfigurarTela(Tarefa tarefaSelecionada)
        {
            txtId.Text = tarefaSelecionada.id.ToString();

            txtTitulo.Text = tarefaSelecionada.titulo;

            cmbPrioridade.SelectedItem = tarefaSelecionada.prioridade;

            txtDataCriacao.Value = tarefaSelecionada.dataCriacao;
        }
    }
}
