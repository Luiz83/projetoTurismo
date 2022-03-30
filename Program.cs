using projetoTurismo.Classess;
namespace projetoTurismo;

public class Program
{
    static void Main(string[] args)
    {
        
    }
}

/*Desafio de hoje:

Seu cliente é uma agência de turismo que vende pacotes de viagem 
ou somente passagens aéreas. 
Os pacotes possuem, além da data de ida, 
a data da volta e o valor do pacote, uma série de serviços 
que ficam a critério do cliente contratar, 
como: almoço (que possui valor), jantar (que possui valor), 
café da manhã (que possui valor) e passeios locais (que possuem valor, 
local do passeio e horário). 
Já a passagem aérea contém a empresa aérea, classe, poltrona, valor, 
horário de embarque, data da passagem, 
voo (que deverá ter numero, horário, destino e origem) 
e a escala (formada pela duração, local e horário de chegada) 
e qualquer outro atributo que julgar necessário. 
Portanto as vendas poderão conter uma ou várias passagens aéreas 
assim como um ou vários pacotes de turismo, 
além da forma de pagamento (dinheiro ou cartão de débito/crédito), 
dos dados do cliente (nome, cpf e nascimento) e do valor total. 
Considere também dados comuns para armazenamento de dados dos funcionários.

⦁	Garanta que os valores monetários não aceitem valores negativos;
⦁	A Passagem deve possuir um método getResumo(), 
que irá exibir somente nome do cliente, poltrona e valor;
⦁	Para o atributo forma de pagamento garanta que seja 
armazenado somente “VISTA” ou “CRÉDITO” ou “DÉBITO”.
⦁	Para o atributo nome do cliente, crie um método para retornar 
somente o primeiro nome.
⦁	Garanta que o nome do cliente tenha entre 5 e 55 caracteres. 
Caso a regra seja quebrada considere o valor “NOME INVALIDO”.
⦁	Crie um método aplicar desconto() que deverá atualizar o atributo
 total com 5% de desconto se o valor do total estiver entre 500 e 5000, se 
 o total for maior que 5000 atualize o total considerando 10% de desconto. 
 O método deve retornar: “Total atualizado, 
 foi considerado o valor de desconto: <valor do desconto>”.*/