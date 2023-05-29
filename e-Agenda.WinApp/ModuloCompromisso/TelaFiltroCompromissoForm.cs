namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaFiltroCompromissoForm : Form
    {
        public TelaFiltroCompromissoForm()
        {
            InitializeComponent();
        }

        public StatusCompromissoEnum ObterStatus()
        {
            if (rdbFuturos.Checked)
            {
                return StatusCompromissoEnum.Futuros;
            }
            else if (rbdPassados.Checked)
            {
                return StatusCompromissoEnum.Passados;
            }
            else
            {
                return StatusCompromissoEnum.Todos;
            }
        }

        public DateTime ObterDataInicio()
        {
            return txtDataInicio.Value;
        }

        public DateTime ObterDataFinal()
        {
            return txtDataFinal.Value;
        }

        private void rdbFuturos_CheckedChanged(object sender, EventArgs e)
        {
            txtDataInicio.Enabled = !txtDataInicio.Enabled;
            txtDataFinal.Enabled = !txtDataFinal.Enabled;
        }

    }
}
