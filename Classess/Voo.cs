namespace projetoTurismo.Classess
{
    public class Voo
    {
        public string Empresa { get; set; }
        public int Numero { get; set; }
        public DateTime DataPassagem { get; set; }
        public DateTime HoraEmbarque { get; set; }
        public string Partida { get; set; }
        public string Destino { get; set;}

        public Voo(string empresa, int numero, DateTime horaEmbarque, DateTime dataEmbarque, string partida, string destino)
        {
            Empresa = empresa;
            Numero = numero;
            DataPassagem = dataEmbarque;
            HoraEmbarque = horaEmbarque;
            Partida = partida;
            Destino = destino;
        }

    }
}