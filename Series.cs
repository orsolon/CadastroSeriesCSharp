using System;

namespace CadastroSeries
{
    public class Series : EntidadeBase
    {

        private Genero genero { get; set; }
        private string titulo { get; set; }
        private string descricao { get; set; }
        private bool excluido {get; set;}

         public Series(int id, Genero genero, string titulo, string descricao)
        {
            this.genero = genero;
            this.titulo = titulo;
            this.descricao = descricao;
            this.id = id;
            this.excluido = false;
        }

        public override string ToString()
        {
            string retorno = " ";
            retorno += "Gênero:" + this.genero + Environment.NewLine;
            retorno += "Título: " + this.titulo + Environment.NewLine;
            retorno += "Descrição : " + this.descricao + Environment.NewLine;
            retorno += "Excluido: " + this.excluido;
            return retorno;
        } 

        public string RetornaTitulo()
        {
            return this.titulo;
        }

        public int RetornaID()
        {
            return this.id;
        }

        public void Excluir()
        {
            this.excluido = true;
        }
    }
}