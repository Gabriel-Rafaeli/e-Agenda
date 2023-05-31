using e_Agenda.WinApp.ModuloDespesas;
using e_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCategoria
{
    [Serializable]
    public class Categoria : EntidadeBase<Categoria>
    {
        public string Titulo { get; set; }

        public List<Despesa> Despesas { get; set; }

        public Categoria(string titulo)
        {
            Titulo = titulo;
            Despesas = new List<Despesa>();
        }

        public override void AtualizarInformacoes(Categoria registroAtualizado)
        {
            this.Titulo = registroAtualizado.Titulo;
        }

        public override string[] Validar()
        {
            return new string[] { };
        }

        public override string ToString()
        {
            return Titulo;
        }

        public override bool Equals(object? obj)
        {
            return obj is Categoria categoria &&
                   id == categoria.id &&
                   Titulo == categoria.Titulo;
        }
    }
}
