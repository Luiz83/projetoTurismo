namespace projetoTurismo.Classess
{
    public class PacotesDeViagem
    {
        public Passagens PassagemIda { get; set; }
        public Passagens PassagemVolta { get; set; }
        public Passageiro Titular { get; set; }
        public double ValorPacote { get; set; }
        public List<Servicos> ServicosPacote { get; set; }

        public PacotesDeViagem(Passagens passagemIda, Passagens passagemVolta)
        {
            PassagemIda = passagemIda;
            PassagemVolta = passagemVolta;
            Titular = PassagemIda.Passageiro;
        }

        public void AdicionarServicos()
        {
            Console.WriteLine("Você deseja adicionar um serviço no seu pacote? 1 = sim / 2 = não");
            var opcao = int.Parse(Console.ReadLine());
            while (opcao == 1)
            {
                EscolherServico();
                Console.WriteLine("Você deseja adicionar outro serviço no seu pacote? 1 = sim / 2 = não");
                opcao = int.Parse(Console.ReadLine());
            }
            ValorPacote = CalcularValor();
        }

        public void EscolherServico()
        {
            Console.WriteLine("Qual serviço deseja adicionar ?");
            Console.WriteLine("1 = Almoço incluso / 2 = Janta inclusa / 3 = Café da Manhã Incluso / 4 = Passeios Turisticos");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    ServicosPacote.Add(new AlmocoServico());
                    Console.WriteLine("Almoço adicionado ao seu pacote");
                    break;
                case 2:
                    ServicosPacote.Add(new JantarServico());
                    Console.WriteLine("Jantar adicionado ao seu pacote");
                    break;
                case 3:
                    ServicosPacote.Add(new CafeDaManhaServico());
                    Console.WriteLine("Café da manhã adicionado ao seu pacote");
                    break;
                case 4:
                    EscolherPasseio();
                    break;
                default:
                    Console.WriteLine("Opção selecionada inválida, tente de novo");
                    EscolherServico();
                    return;
            }
        }

        public void EscolherPasseio()
        {
            Console.WriteLine("Qual passeio deseja adicionar ?");
            Console.WriteLine("1 = Dia na Praia / 2 = Tour pela cidade / 3 = Rota gastronômica?");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    ServicosPacote.Add(new PasseiosTuristicosServicos("Dia na Praia", 150, "Praia", "08:00"));
                    Console.WriteLine("Dia na praia adicionado ao seu pacote");
                    break;
                case 2:
                    ServicosPacote.Add(new PasseiosTuristicosServicos("Tour na Cidade", 70, "Hotel", "10:00"));
                    Console.WriteLine("Tour na cidae adicionado ao seu pacote");
                    break;
                case 3:
                    ServicosPacote.Add(new PasseiosTuristicosServicos("Rota gastronômica", 300, "Hotel", "13:00"));
                    Console.WriteLine("Rota gastronômica adicionado ao seu pacote");
                    break;
                default:
                    Console.WriteLine("Opção selecionada inválida, tente de novo");
                    EscolherPasseio();
                    return;
            }
        }

        public string BuscarResumo (){
            return $"Passagem em nome de {Titular} no valor de R${ValorPacote}";
        }

        private double CalcularValor()
        {
            double total = 0;
            total = PassagemIda.Valor + PassagemVolta.Valor;
            for (int i = 0; i < ServicosPacote.Count; i++)
            {
                total = total + ServicosPacote[i].Valor;
            }
            return total;
        }
    }
}
/*
Os pacotes possuem, além da data de ida, 
a data da volta e o valor do pacote, uma série de serviços 
que ficam a critério do cliente contratar, 
como: almoço (que possui valor), jantar (que possui valor), 
café da manhã (que possui valor) e passeios locais (que possuem valor, 
local do passeio e horário). 
*/