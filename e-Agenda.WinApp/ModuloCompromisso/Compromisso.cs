using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    [Serializable]
    public class Compromisso : EntidadeBase<Compromisso>
    {
        public string assunto;

        public DateTime data;

        public TimeSpan horarioInicio;

        public TimeSpan horarioFinal;

        public Contato contato;

        public string localPresencial;

        public string localOnline;

        public TipoLocalEnum tipoLocal;

        public Compromisso(string assunto, DateTime data, TimeSpan horarioInicio, TimeSpan horarioFinal, 
            Contato contato, string local, TipoLocalEnum tipoLocal)
        {
            this.assunto = assunto;
            this.data = data;
            this.horarioInicio = horarioInicio;
            this.horarioFinal = horarioFinal;
            this.contato = contato;            
            this.tipoLocal = tipoLocal;

            if (tipoLocal == TipoLocalEnum.Online)
                this.localOnline = local;
            else
                this.localPresencial = local;
        }

        public override string ToString()
        {
            return "Id: " + id + ", " + assunto + ", Data: " + data;
        }

        public override void AtualizarInformacoes(Compromisso registroAtualizado)
        {
            this.assunto = registroAtualizado.assunto;
            this.data = registroAtualizado.data;
            this.horarioInicio = registroAtualizado.horarioInicio;
            this.horarioFinal = registroAtualizado.horarioFinal;
            this.contato = registroAtualizado.contato;
            this.tipoLocal = registroAtualizado.tipoLocal;

            if (registroAtualizado.tipoLocal == TipoLocalEnum.Online)
                this.localOnline = registroAtualizado.localOnline;
            else
                this.localPresencial = registroAtualizado.localPresencial;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(assunto))
                erros.Add("O campo 'assunto' é obrigatório");            

            return erros.ToArray();
        }

        public override bool Equals(object? obj)
        {
            return obj is Compromisso compromisso &&
                   id == compromisso.id &&
                   assunto == compromisso.assunto &&
                   data == compromisso.data &&
                   horarioInicio.Equals(compromisso.horarioInicio) &&
                   horarioFinal.Equals(compromisso.horarioFinal) &&
                   EqualityComparer<Contato>.Default.Equals(contato, compromisso.contato) &&
                   localPresencial == compromisso.localPresencial &&
                   localOnline == compromisso.localOnline &&
                   tipoLocal == compromisso.tipoLocal;
        }
    }
}
