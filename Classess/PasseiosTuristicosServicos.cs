namespace projetoTurismo.Classess
{
    public class PasseiosTuristicosServicos : Servicos
    {
        public string LocalPasseio { get; set; }
        public string HorarioPasseio { get; set; }
        public PasseiosTuristicosServicos(string nome, double valor, string local, string horario ) : base(nome, valor)
        {
            LocalPasseio = local;
            HorarioPasseio = horario;
        }
    }
}