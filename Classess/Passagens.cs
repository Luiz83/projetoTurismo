namespace projetoTurismo.Classess
{
    public class Passagens
    {
        
        public int PrimeiraClasse { get; set; }
        public int Assento { get; set; }
        public double Valor { get; set; }
        public Passageiro Passageiro { get; set; }
        public Voo Voo { get; set; }

        public Passagens(int primeiraclasse, double valor, int assento, Passageiro passageiro)
        {
            PrimeiraClasse = primeiraclasse;
            Valor = CalcularValor(valor);
            Assento = assento;
            Passageiro = passageiro;
            Voo = new Voo ("Latam", 864, DateTime.Parse("22:00:00"), DateTime.Parse("03/04/2022"), "São Paulo", "Fortaleza");
        }

        public string BuscarResumo (){
            return $"Passagem em nome de {Passageiro.PrimeiroNome()} na poltrona {Assento} no valor de R${Valor}";
        }

        private double CalcularValor(double valor)
        {
            if (PrimeiraClasse == 1)
            {
                return valor = valor * 1.5;
            }
            else
            {
                return Math.Abs(valor);
            }
        }



    }
}

/*
Já a passagem aérea contém a empresa aérea, classe, poltrona, valor, 
horário de embarque, data da passagem, 
voo (que deverá ter numero, horário, destino e origem) 
e a escala (formada pela duração, local e horário de chegada) 
e qualquer outro atributo que julgar necessário. 
*/