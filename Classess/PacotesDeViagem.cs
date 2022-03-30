namespace projetoTurismo.Classess
{
    public class PacotesDeViagem
    {
        public Passagens PassagemIda {get;set;}
        public Passagens PassagemVolta {get;set;}
        public double ValorPacote {get;set;}
        public List<Servicos> ServicosPacote {get;set;}
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