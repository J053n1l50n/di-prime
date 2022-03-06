namespace Nova_pasta_(3).Classe
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int ano { get; set; }

        private bool Excluido{ get; set; }

        public Serie(int ID, Genero Genero, string Titulo, string Descricao, int ano )
        {
            this.ID =ID;
            this.Genero = Genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno ="";
            retorno+= "Gênero: " + this.Genero + Envioronment.Newline;
            retorno+= "Titulo: " + this.Titulo + Envioronment.Newline;
            retorno+= "Resumo: " + this.Descricao + Envioronment.Newline;
            retorno+= "Ano de Lançamento: " + this.ano+ Envioronment.Newline;
            retorno+= "Excluido: " + this.Excluido;
            return retorno;
        } 
        public string voltaTitulo()
        {
            return this.Titulo;
        }

        public int voltaID()
        {
            return this.ID;
        }

        public bool VoltaApagado(){
            return this.Excluido
        }


        public void Exclui(){
            this.Excluido = true;
        }
    }  

}