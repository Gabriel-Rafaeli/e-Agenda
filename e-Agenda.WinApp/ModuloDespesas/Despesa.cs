using e_Agenda.WinApp.ModuloCategoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloDespesas
{
    public class Despesa : EntidadeBase<Despesa>
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public FormaPagamentoEnum TipoPagamento { get; set; }
        public List<Categoria> CategoriasDaDespesa { get; set; }

        public Despesa(string descricao, decimal valor, DateTime data, FormaPagamentoEnum tipoPagamento)
        {
            Descricao = descricao;
            Valor = valor;
            Data = data;
            TipoPagamento = tipoPagamento;
            CategoriasDaDespesa = new List<Categoria>();
        }

        public override void AtualizarInformacoes(Despesa registroAtualizado)
        {
            this.Descricao = registroAtualizado.Descricao;
            this.Valor = registroAtualizado.Valor;
            this.Data = registroAtualizado.Data;
            this.TipoPagamento = registroAtualizado .TipoPagamento;
        }

        public override string[] Validar()
        {
            List<string> erros = new();

            if (CategoriasDaDespesa.Count == 0)
                erros.Add("É necessário incluir uma categoria.");

            else if (Descricao.Trim() == string.Empty)
                erros.Add("É necessário incluir a descrição.");

            else if (Valor <= 0)
                erros.Add("O valor precisa ser número positivo.");

            else if (Data == default || Data.ToString() == string.Empty)
                erros.Add("è necessário incluir a data da despesa.");

            return erros.ToArray();
        }

        public override string ToString()
        {
            return "Id: " + id + ", " + Descricao + ", Valor: " + Valor + ", Data: " + Data + ", Forma Pagamento: " + TipoPagamento;
        }
    }
}
