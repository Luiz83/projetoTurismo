namespace projetoTurismo.Classess
{
    public class Passagens
    {
        public string Empresa { get; set; }
        public bool PrimeiraClasse { get; set; }
        public int Assento { get; set; }
        public double Valor { get; set; }
        public string HoraEmbarque { get; set; }
        public string DataPassagem { get; set; }
        public Passageiro Passageiro{get;set;}

        public Passagens(string empresa, string horaembarque, string datapassagem, bool primeiraclasse, double valor, int assento, Passageiro passageiro)
        {
            Empresa = empresa;
            HoraEmbarque = horaembarque;
            DataPassagem = datapassagem;
            PrimeiraClasse = primeiraclasse;
            Valor = CalcularValor(valor);
            Assento = assento;
            Passageiro =passageiro;
        }

        private double CalcularValor(double valor)
        {
            if (PrimeiraClasse == true)
            {
                return valor = valor * 1.5;
            }
            else
            {
                return valor;
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