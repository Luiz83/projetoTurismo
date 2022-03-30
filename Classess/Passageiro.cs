namespace projetoTurismo.Classess
{
    public class Passageiro
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string DataDeNascimento { get; set; }

        public Passageiro(string nome, string cpf, string dataDeNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            DataDeNascimento = dataDeNascimento;
        }
    }
}

/*
dos dados do cliente (nome, cpf e nascimento) e do valor total
*/