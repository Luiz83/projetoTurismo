namespace projetoTurismo.Classess
{
    public class Vendas
    {
        public List<PacotesDeViagem> CarrinhoPacotes { get; set; }
        public List<Passagens> CarrinhoPassagens { get; set; }
        public string FormaDePagamento { get; set; }
        public Passageiro Cliente { get; set; }
        public Passageiro Titular { get; set; }
        public double ValorTotal { get; set; }

        public Vendas()
        {
            CarrinhoPacotes = new List<PacotesDeViagem>();
            CarrinhoPassagens = new List<Passagens>();
        }

        public void IniciarVenda()
        {
            Console.WriteLine("Bem vindo a DODEV Turismo");
            Cliente = RequisitarDadosCliente();
            EscolherProduto();
            FinalizarVenda();
        }

        public Passageiro RequisitarDadosCliente()
        {

            var nome = RequisitarNome();
            Console.WriteLine("Digite seu CPF. Somente números!");
            var cpf = Console.ReadLine();
            Console.WriteLine("Informe sua data de nascimento no formato mês/dia/ano");
            var dataDeNascimento = DateTime.Parse(Console.ReadLine());
            return new Passageiro(nome, cpf, dataDeNascimento);
        }

        public string RequisitarNome()
        {
            do
            {
                Console.WriteLine("Digite seu nome");
                var nome = Console.ReadLine();
                if ((nome.Length >= 5) & (nome.Length <= 55))
                {
                    return nome;
                }
                Console.WriteLine("Seu nome precisa ter entre 5 e 55 caracteres, tente novamente!");
            } while (true);
        }

        public void EscolherProduto()
        {
            var opcaoWhile = 1;
            do
            {
                Console.WriteLine("Você deseja comprar uma passagem individual ou um pacote de viagem? 1 - Passagem / 2 - Pacote");
                var opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    EscolherTitular();
                    CarrinhoPassagens.Add(EscolherPassagem());
                }
                else if (opcao == 2)
                {
                    EscolherTitular();
                    var pacoteAdd = EscolherPacote();
                    pacoteAdd.AdicionarServicos();
                    CarrinhoPacotes.Add(pacoteAdd);

                }
                else
                {
                    Console.WriteLine("Você inseriu uma opcao invalida");
                }
                Console.WriteLine("Se deseja continuar comprando tecle 1, se deseja finalizar as compras tecle 2");
                opcaoWhile = int.Parse(Console.ReadLine());
            } while (opcaoWhile == 1);
        }

        public void EscolherTitular()
        {
            Console.WriteLine("Você deseja comprar para você ou outra pessoa? 1 - Eu mesmo / 2 - Outra pessoa");
            var opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                Titular = Cliente;
            }
            else if (opcao == 2)
            {
                Titular = RequisitarDadosCliente();
            }
            else
            {
                Console.WriteLine("Você inseriu uma opcao invalida, tente novamente!");
                EscolherTitular();
            }
            return;
        }

        public Passagens EscolherPassagem()
        {
            Console.WriteLine("Voce deseja um assento na primeira classe? 1 -Sim / 2 - Não");
            var primeiraclasse = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual assento você deseja?");
            var assento = int.Parse(Console.ReadLine());
            return new Passagens(primeiraclasse, 500, assento, Titular);
        }

        public PacotesDeViagem EscolherPacote()
        {
            Console.WriteLine("Vamos escolher a passagem de ida!");
            var passagemIda = EscolherPassagem();
            Console.WriteLine("Vamos escolher a passagem de volta!");
            var passagemVolta = EscolherPassagem();
            return new PacotesDeViagem(passagemIda, passagemVolta);
        }

        public void FinalizarVenda()
        {
            Console.WriteLine("Este é o resumo da sua compra: ");
            ExibirResumoDaVenda();
            DefinirMetodoDePagamento();
            Console.WriteLine("Método escolhido foi: " + FormaDePagamento);
            Console.WriteLine("Compra finalizada com sucesso boa viagem!");
        }

        public void ExibirResumoDaVenda()
        {

            for (int i = 0; i < CarrinhoPassagens.Count; i++)
            {
                Console.WriteLine(CarrinhoPassagens[i].BuscarResumo());
            }
            for (int i = 0; i < CarrinhoPacotes.Count; i++)
            {
                Console.WriteLine(CarrinhoPacotes[i].BuscarResumo());
            }
            ValorTotal = CalcularValorTotal();
            Console.WriteLine($"O valor total da sua compra é de R${ValorTotal}");
            VerificarDesconto();
        }

        public void DefinirMetodoDePagamento()
        {
            Console.WriteLine("Qual será o método de pagamento?");
            Console.WriteLine(" VISTA ou CREDITO ou DEBITO ");
            string metodoDePagamento = Console.ReadLine();
            if ((metodoDePagamento == "VISTA") || (metodoDePagamento == "CREDITO") || (metodoDePagamento == "DEBITO"))
            {
                FormaDePagamento = metodoDePagamento;
            }
            else
            {
                Console.WriteLine("Você não inseriu uma opção válida, tente novamente");
                DefinirMetodoDePagamento();
            }
            return;
        }



        public double CalcularValorTotal()
        {
            double total = 0;
            for (int i = 0; i < CarrinhoPacotes.Count; i++)
            {
                total = total + CarrinhoPacotes[i].ValorPacote;
            }
            for (int i = 0; i < CarrinhoPassagens.Count; i++)
            {
                total = total + CarrinhoPassagens[i].Valor;
            }
            return Math.Abs(total);
        }

        public void VerificarDesconto()
        {
            if (ValorTotal > 5000)
            {
                ValorTotal = ValorTotal * 0.9;
                Console.WriteLine($"Desconto de 10% aplicado o valor final é de R${ValorTotal}");
            }
            else if (ValorTotal > 500)
            {
                ValorTotal = ValorTotal * 0.95;
                Console.WriteLine($"Desconto de 5% aplicado o valor final é de R${ValorTotal}");
            }
        }
    }
}

/*
Portanto as vendas poderão conter uma ou várias passagens aéreas 
assim como um ou vários pacotes de turismo, 
além da forma de pagamento (dinheiro ou cartão de débito/crédito), 
dos dados do cliente (nome, cpf e nascimento) e do valor total. 
Considere também dados comuns para armazenamento de dados dos funcionários.
*/