using System;
using System.Diagnostics.Metrics;

namespace ExerciciosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            **Crie um Programa em C# que receba três números do usuário, informe na tela qual é o MENOR deles ou exiba se eles são iguais.**

            int N1, N2, N3;

            Console.WriteLine("Digite o primeiro número: ");
            N1= int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            N3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultado");

            if (N1<N2 && N1<N3)
            {
                Console.WriteLine("O primeiro número é o menor ");
            }
            else if (N2 < N1 && N2 < N3)
            {
                Console.WriteLine("O segundo número é o menor ");
            }
            else if (N3 < N1 && N3 < N3)
            {
                Console.WriteLine("O terceiro número é o menor ");
            }
            else if(N1 == N2 && N1 == N3 && N2 == N3){
                Console.WriteLine("Numeros iguais");
            }
            else
            {
               Console.WriteLine("A operacao falhou! Tente novamente");
            }*/

            /**Crie um Programa em C# que, receba três números do usuário, informe na tela qual é o MAIOR deles ou exiba se eles são iguais. ** 

            int N1, N2, N3;

            Console.WriteLine("Digite o primeiro número: ");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            N3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultado");

            if (N1 > N2 && N1 > N3)
            {
                Console.WriteLine("O primeiro número é o MAIOR ");
            }
            else if (N2 > N1 && N2 > N3)
            {
                Console.WriteLine("O segundo número é o MAIOR ");
            }
            else if (N3 > N1 && N3 > N2
                )
            {
                Console.WriteLine("O terceiro número é o MAIOR ");
            }
            else if (N1 == N2 && N1 == N3 && N2 == N3)
            {
                Console.WriteLine("Numeros iguais");
            }
            else
            {
                Console.WriteLine("A operacao falhou! Tente novamente");
            }*/

            int urgencia;

            Console.WriteLine("Descreva a sua solicitação: ");
            Console.ReadLine();
            Console.WriteLine("Em uma escala de 0 a 10, qual é o seu nível de urgência? ");
            Console.ReadLine();
            urgencia = int.Parse(Console.ReadLine());

            if (urgencia > 0 && urgencia <= 3)
            {
                Console.WriteLine("Sua urgencia foi recebida e é de nível: BAIXO");
            }
            else if (urgencia > 3 && urgencia <= 6)
            {
                Console.WriteLine("Sua urgencia foi recebida e é de nível: MÉDIA");
            }
            else if (urgencia > 6 && urgencia <= 9)
            {
                Console.WriteLine("Sua urgencia foi recebida e é de nível: ALTO");
            }
            else
            {
                Console.WriteLine("Sua urgência foi recebida e é de nível: GRAVE");
            }
        }
    }
}