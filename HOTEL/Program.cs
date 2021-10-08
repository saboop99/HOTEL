using System;

namespace HOTEL
{
    class Program
    {
        //RAFAEL DO NASCIMENTO RODRIGUES 210211


        static void Main(string[] args)
        {
            //Declaração da matriz Estudante, com tamanho 10
            Estudante[] vect = new Estudante[10];

            //pedir ao usuário digitar a quantidade de quartos alugados, do total de 10
            Console.WriteLine("Quantos quartos vão ser alugados?");
            //conversão e leitura do dado digitado para int
            int n = int.Parse(Console.ReadLine());

            //condicional para a matriz (começa no 1[pois o quarto começa no 1 e não no 0], é menor ou igual ao numero de quartos digitados, vai acrescentando na vairavel i)
            for (int i = 1; i <= n; i++)
            {
                //pular linha
                Console.WriteLine();
                
                //mostrar o numero do hospede, como a variavel i da condicional for é 1, a contagem aqui começa a partir do 1, então é mostrado na tela "Hospede #1"
                Console.WriteLine($"Hospede #{i}");
                //informar ao usuario para ele digitar o nome
                Console.WriteLine("Nome");
                //leitura e armazenamento dos dados digitados para string nome
                string nome = Console.ReadLine();
                //informar ao usuario para ele digitar o email
                Console.WriteLine("Email");
                //leitura e armazenamento dos dados digitaos para string email
                string email = Console.ReadLine();
                //informar ao usuario para ele digitar o numero do quarto
                Console.WriteLine("Quarto: ");
                //leitura e conversão dos dados digitados para int
                int quarto = int.Parse(Console.ReadLine());
                //criação do vetor vect[quarto] para instanciar o nome e o email inputados anteriormente, para o quarto alugado
                vect[quarto] = new Estudante(nome, email);
            }

            //pular linha
            Console.WriteLine();
            //mostrar para o usuario que a proxima informação se trata dos quartos ocupados
            Console.WriteLine("Quartos ocupados: ");
            //condicional para a matriz (começa no 0, é menor que o numero de quartos totais, vai acrescentando na vairavel i)
            for (int i = 0; i < 10; i++)
            {
                //condicional para se o numero do quarto for diferente de nulo (null para se deixar automaticamente os quartos em ordem numerica)
                if(vect[i] != null)
                {
                    //mostrar ao usuario todos os quartos ocupados e seus respectivos ocupantes armazenados na variavel i
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

        }
    }
}
