namespace e_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        private RepositorioTarefa repositorioTarefa;
        private TabelaTarefaControl tabelaTarefas;

        public ControladorTarefa(RepositorioTarefa repositorioTarefa)
        {
            this.repositorioTarefa = repositorioTarefa;
        }

        #region tooltips
        public override string ToolTipInserir => "Inserir nova Tarefa";

        public override string ToolTipEditar => "Editar Tarefa existente";

        public override string ToolTipExcluir => "Excluir Tarefa existente";

        public override string ToolTipFiltrar => "Filtrar Tarefas";

        public override string ToolTipAdicionarItens => "Adicionar Itens na Tarefa";

        public override string ToolTipConcluirItens => "Concluir Itens da Tarefa";

        #endregion

        public override bool FiltrarHabilitado => true;

        public override bool AdicionarItensHabilitado => true;

        public override bool ConcluirItensHabilitado => true;


        public override void Inserir()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm(edicaoDeTarefa: false);

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tarefa novaTarefa = telaTarefa.ObterTarefa();

                repositorioTarefa.Inserir(novaTarefa);

                CarregarTarefas();
            }
        }

        public override void Editar()
        {
            Tarefa tarefaSelecionada = ObterTarefaSelecionada();

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Edição de Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            TelaTarefaForm telaTarefa = new TelaTarefaForm(edicaoDeTarefa: true);

            telaTarefa.ConfigurarTela(tarefaSelecionada);

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.ObterTarefa();

                repositorioTarefa.Editar(tarefa.id, tarefa);

                CarregarTarefas();
            }
        }

        public override void Excluir()
        {
            Tarefa tarefaSelecionada = ObterTarefaSelecionada();

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Exclusão de Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a tarefa {tarefaSelecionada.titulo}?",
                "Exclusão de Tarefa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTarefa.Excluir(tarefaSelecionada);

                CarregarTarefas();
            }
        }


        private Tarefa ObterTarefaSelecionada()
        {
            int id = tabelaTarefas.ObterIdSelecionado();

            return repositorioTarefa.SelecionarPorId(id);
        }
        public override void Adicionar()
        {
            Tarefa tarefaSelecionada = ObterTarefaSelecionada();

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Adição de Itens da Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            TelaCadastroItensTarefaForm telaCadastroItensTarefa = new TelaCadastroItensTarefaForm(tarefaSelecionada);

            DialogResult opcaoEscolhida = telaCadastroItensTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                List<ItemTarefa> itensParaAdicionar = telaCadastroItensTarefa.ObterItensCadastrados();

                foreach (ItemTarefa item in itensParaAdicionar)
                {
                    tarefaSelecionada.AdicionarItem(item);
                }

                repositorioTarefa.Editar(tarefaSelecionada.id, tarefaSelecionada);
                CarregarTarefas();
            }
        }

        public override void ConcluirItens()
        {
            Tarefa tarefaSelecionada = ObterTarefaSelecionada();

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Atualização de Itens da Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            TelaAtualizacaoItensTarefaForm telaAtualizacaoItensTarefa = new TelaAtualizacaoItensTarefaForm(tarefaSelecionada);

            DialogResult opcaoEscolhida = telaAtualizacaoItensTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                List<ItemTarefa> itensMarcados = telaAtualizacaoItensTarefa.ObterItensMarcados();

                List<ItemTarefa> itensPendentes = telaAtualizacaoItensTarefa.ObterItensPendentes();

                foreach (ItemTarefa item in itensMarcados)
                {
                    tarefaSelecionada.ConcluirItem(item);
                }

                foreach (ItemTarefa item in itensPendentes)
                {
                    tarefaSelecionada.DesmarcarItem(item);
                }

                repositorioTarefa.Editar(tarefaSelecionada.id, tarefaSelecionada);

                CarregarTarefas();
            }
        }

        public override void Filtrar()
        {
            TelaFiltroTarefaForm telaFiltroTarefa = new TelaFiltroTarefaForm();

            DialogResult opcaoEscolhida = telaFiltroTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                List<Tarefa> tarefas;

                StatusTarefaEnum status = telaFiltroTarefa.ObterFiltroTarefa();

                switch (status)
                {                   
                    case StatusTarefaEnum.Pendentes:
                        tarefas = repositorioTarefa.SelecionarPendentes();
                        break;

                    case StatusTarefaEnum.Concluidas:
                        tarefas = repositorioTarefa.SelecionarConcluidas();
                        break;

                    default:
                        tarefas = repositorioTarefa.SelecionarTodosOrdenadosPorPrioridade();
                        break;
                }

                CarregarTarefas(tarefas);
            }
        }

        private void CarregarTarefas(List<Tarefa> tarefas)
        {
            tabelaTarefas.AtualizarRegistros(tarefas);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {tarefas.Count} tarefa(s)");
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodosOrdenadosPorPrioridade();

            tabelaTarefas.AtualizarRegistros(tarefas);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {tarefas.Count} tarefa(s)");
        }

        public override UserControl ObterListagem()
        {            
            if (tabelaTarefas ==  null)
                tabelaTarefas = new TabelaTarefaControl();


            CarregarTarefas();

            return tabelaTarefas;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";
        }
    }
}
