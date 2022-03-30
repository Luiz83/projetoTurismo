namespace projetoTurismo.Classess
{
    public class Servicos
    {
        public string Nome{get;set;}
        public double Valor{get;set;}
        public Servicos(string nome, double valor){
            Nome = nome;
            Valor = valor;
        }
    }
}