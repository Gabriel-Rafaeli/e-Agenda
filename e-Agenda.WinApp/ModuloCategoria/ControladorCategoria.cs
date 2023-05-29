using e_Agenda.WinApp.ModuloDespesas;
using e_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public class ControladorCategoria : ControladorBase
    {
        RepositorioCategoria repositorioCategoria;
        TabelaCategoriaControl tabelaCategoria;
        RepositorioDespesa repositorioDespesa;
        public ControladorCategoria(RepositorioCategoria repositorioCategoria, RepositorioDespesa repositorioDespesa)
        {
            this.repositorioCategoria = repositorioCategoria;
            this.repositorioDespesa = repositorioDespesa;
        }

        public override string ToolTipInserir => "Inserir Categoria";

        public override string ToolTipEditar => "Editar Categoria";

        public override string ToolTipExcluir => "Excluir Categoria";

        public override void Inserir()
        {
            TelaCategoriaForm telaCategoria = new TelaCategoriaForm();

            DialogResult opcaoEscolhida = telaCategoria.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Categoria novaCategoria = telaCategoria.ObterCategoria();

                repositorioCategoria.Inserir(novaCategoria);

                CarregarCategorias();
            }
        }

        public override void Editar()
        {
            Categoria categoriaSelecionada = ObterCategoriaSelecionada();

            if (categoriaSelecionada == null)
            {
                MessageBox.Show("Selecione uma categoria primeiro", "Edição de Categoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            TelaCategoriaForm telaCategoria = new TelaCategoriaForm();

            telaCategoria.ConfigurarTela(categoriaSelecionada);

            DialogResult opcaoEscolhida = telaCategoria.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Categoria categoria = telaCategoria.ObterCategoria();

                repositorioCategoria.Editar(categoria.id, categoria);

                CarregarCategorias();
            }
        }

        public override void Excluir()
        {
            Categoria categoriaSelecionada = ObterCategoriaSelecionada();

            if (categoriaSelecionada == null)
            {
                MessageBox.Show("Selecione uma categia primeiro", "Exclusão de Categoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a categoria {categoriaSelecionada.Titulo}?",
             "Exclusão de Categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCategoria.Excluir(categoriaSelecionada);

                CarregarCategorias();
            }
        }

        private void CarregarCategorias()
        {
            List<Categoria> categorias = repositorioCategoria.SelecionarTodos();

            tabelaCategoria.AtualizarRegistros(categorias);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {categorias.Count} tarefa(s)");
        }

        public override void visualizarCategoria()
        {
            Categoria categoria = ObterCategoriaSelecionada();

            if (categoria == null)
            {
                MessageBox.Show("Selecione uma categoria!");
                return;
            }

            List<Despesa> despesasPorCategoria = repositorioDespesa.ListarDespesasPorCategorias(categoria);

            if (despesasPorCategoria.Count == 0)
            {
                MessageBox.Show("Nenhuma despesa para a categoria selecionada!");
                return;
            }

            TelaVisualizarCategoriaForm tela = new TelaVisualizarCategoriaForm(despesasPorCategoria);

            tela.ShowDialog();

        }

        private Categoria ObterCategoriaSelecionada()
        {
            int id = tabelaCategoria.ObterIdSelecionado();

            return repositorioCategoria.SelecionarPorId(id);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCategoria == null)
                tabelaCategoria = new TabelaCategoriaControl();


            CarregarCategorias();

            return tabelaCategoria;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Categorias";
        }
    }
}
