using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloTarefa;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class RepositorioArquivoBase<TEntidade> : IRepositorio<TEntidade> 
        where TEntidade : EntidadeBase<TEntidade>
    {

        protected ContextoDados contextoDados;
        private int contador;

        public RepositorioArquivoBase(ContextoDados contexto)
        {
            contextoDados = contexto;

            AtualizarContador();
        }

        protected abstract List<TEntidade> ObterRegistros();

        public virtual void Inserir(TEntidade novoRegistro)
        {
            List<TEntidade> listaRegistros = ObterRegistros();

            contador++;
            novoRegistro.id = contador;
            listaRegistros.Add(novoRegistro);

            contextoDados.GravarEmArquivoJson();
        }

        public virtual void Editar(int id, TEntidade registroAtualizado)
        {
            EntidadeBase<TEntidade> registroSelecionada = SelecionarPorId(id);

            registroSelecionada.AtualizarInformacoes(registroAtualizado);

            contextoDados.GravarEmArquivoJson();
        }

        public virtual void Excluir(TEntidade registroSelecionado)
        {
            List<TEntidade> listaRegistros = ObterRegistros();

            listaRegistros.Remove(registroSelecionado);

            contextoDados.GravarEmArquivoJson();
        }

        public virtual TEntidade SelecionarPorId(int id)
        {
            List<TEntidade> listaRegistros = ObterRegistros();
            return listaRegistros.FirstOrDefault(x => x.id == id);
        }

        public virtual List<TEntidade> SelecionarTodos()
        {
            return ObterRegistros();
        }

        private void AtualizarContador()
        {
            if (ObterRegistros().Count > 0)
                contador = ObterRegistros().Max(x => x.id);
        }


        #region//RegistrosEmBinario

        //protected void CarregarRegistrosDoArquivo()
        //{
        //    BinaryFormatter serializador = new BinaryFormatter();

        //    byte[] registroEmBytes = File.ReadAllBytes(NOME_ARQUIVO);

        //    MemoryStream registroStream = new MemoryStream(registroEmBytes);

        //    listaRegistros = (List<TEntidade>)serializador.Deserialize(registroStream);

        //    AtualizarContador();
        //}

        //protected void GravarRegistrosEmArquivo()
        //{
        //    BinaryFormatter serializador = new BinaryFormatter();

        //    MemoryStream registroStream = new MemoryStream();

        //    serializador.Serialize(registroStream, listaRegistros);

        //    byte[] registrosEmBytes = registroStream.ToArray();

        //    File.WriteAllBytes(NOME_ARQUIVO, registrosEmBytes);
        //}
#endregion

        #region//RegistrosEmJason
        //private void GravarRegistroEmArquivoJson()
        //{
        //    JsonSerializerOptions opcoes = new JsonSerializerOptions();
        //    opcoes.IncludeFields = true;
        //    opcoes.WriteIndented = true;

        //    string registrosJson = JsonSerializer.Serialize(listaRegistros, opcoes);

        //    File.WriteAllText(NOME_ARQUIVO, registrosJson);
        //}

        //private void CarregarCompromissosDoArquivoJson()
        //{
        //    JsonSerializerOptions opcoes = new JsonSerializerOptions();
        //    opcoes.IncludeFields = true;

        //    string registrosJson = File.ReadAllText(NOME_ARQUIVO);

        //    if (registrosJson.Length > 0)
        //        listaRegistros = JsonSerializer.Deserialize<List<TEntidade>>(registrosJson, opcoes);
        //}
        #endregion

        #region//RegistrosEmXML

        //private void CarregarRegistrosDoArquivoXML()
        //{
        //    XmlSerializer serializador = new XmlSerializer(typeof(List<Compromisso>));

        //    MemoryStream registroStream = new MemoryStream();

        //    serializador.Serialize(registroStream, listaRegistros);

        //    byte[] compromissosEmBytes = registroStream.ToArray();

        //    File.WriteAllBytes(NOME_ARQUIVO, compromissosEmBytes);
        //}

        //private void CarregarCompromissosDoArquivoXml()
        //{
        //    XmlSerializer serializador = new XmlSerializer(typeof(List<Compromisso>));

        //    byte[] compromissoEmBytes = File.ReadAllBytes(NOME_ARQUIVO);

        //    MemoryStream registroStream = new MemoryStream(compromissoEmBytes);

        //    if (registroStream.Length > 10)
        //    {
        //        listaRegistros = (List<TEntidade>)serializador.Deserialize(registroStream);
        //        AtualizarContador();
        //    }
        //}
        #endregion
    }
}
