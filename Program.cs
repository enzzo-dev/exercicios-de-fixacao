using System;

namespace exercicios_de_fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Condicionais
            Console.WriteLine("Digite o ano atual: ");
            int anoAtual = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora, digite o ano de seu nascimento!");
            int anoNasc = int.Parse(Console.ReadLine());

            int calculo = anoAtual - anoNasc;

            if(calculo >= 16)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Você pode votar, porém até os 16 anos é optativo!");
                Console.ResetColor();
            } else if(calculo >= 18)
            {   
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você tem o ato constitucional obrigatório à votar!");
                Console.ResetColor();
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você não pode votar!");
                Console.ResetColor();
            }

            //Ex 2
            static void  valorAlcool(double a) //Variável a é a quantidade de litros
            {
                double alcool = 4.90;
                double desconto1 = 0.03;
                double desconto2 = 0.05;
                double aDesc1 = alcool * a - desconto1;
                double aDesc2 = alcool * a - desconto2;
                if(a <= 20){
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"O valor a se pagar é: R${aDesc1}");
                    Console.ResetColor();
                } else if(a > 20){
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"O valor a se pagar é: R${aDesc2}");
                    Console.ResetColor();
                }
            }
             static void  valorGasolina(double b) //Variável a é a quantidade de litros
            {
                double gasolina = 5.30;
                double desconto1 = 0.04;
                double desconto2 = 0.06;
                double aDesc1 = gasolina * b - desconto1;
                double aDesc2 = gasolina * b - desconto2;
                if(b <= 20){
                   Console.WriteLine($"O valor a se pagar é: R${aDesc1}");
                } else if(b > 20){
                    Console.WriteLine($"O valor a se pagar é: R${aDesc2}");
                }
            }

            Console.WriteLine("Qual tipo de combustivel você deseja colocar?");''
        }
    }
}
