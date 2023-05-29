namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaFiltroTarefaForm : Form
    {
        public TelaFiltroTarefaForm()
        {
            InitializeComponent();
        }

        public StatusTarefaEnum ObterFiltroTarefa()
        {
            if (rdbConcluidas.Checked == true)            
                return StatusTarefaEnum.Concluidas;

            else if (rdbPendentes.Checked == true)
                return StatusTarefaEnum.Pendentes;

            return StatusTarefaEnum.Todos;
        }
    }
}
