using System;

namespace exercicios_de_fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex: 1
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
            double valorAlcool(double a) //Variável a é a quantidade de litros
            {
                double alcool = 4.90;
                double desconto1 = 0.03;
                double desconto2 = 0.05;
                double aDesc1 = alcool * a - desconto1;
                double aDesc2 = alcool * a - desconto2;
                if(a <= 20){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O valor a se pagar é: R${aDesc1}");
                    Console.ResetColor();
                } else if(a > 20){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O valor a se pagar é: R${aDesc2}");
                    Console.ResetColor();
                }
                return 0;
            }
             double valorGasolina(double b) //Variável a é a quantidade de litros
            {
                double gasolina = 5.30;
                double desconto1 = 0.04;
                double desconto2 = 0.06;
                double aDesc1 = gasolina * b - desconto1;
                double aDesc2 = gasolina * b - desconto2;
                if(b <= 20){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O valor a se pagar é: R${aDesc1}");
                    Console.ResetColor();
                } else if(b > 20){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O valor a se pagar é: R${aDesc2}");
                    Console.ResetColor();
                }
                return 0;
            }

            //Ex: 2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Qual tipo de combustivel você deseja colocar? -G (Gasolina) ou -A (Alcool)");
            Console.ResetColor();
            string combus = Console.ReadLine();

            if(combus == "G" || combus == "g"){

                Console.WriteLine("Quantos litros de gasolina você deseja colocar?");
                double litros = double.Parse(Console.ReadLine());
                Console.WriteLine($"{valorGasolina(litros)}");

            }else if(combus == "A" || combus == "a"){

                Console.WriteLine("Quantos litros de gasolina você deseja colocar?");
                double litrosA = double.Parse(Console.ReadLine());
                Console.WriteLine($"{valorAlcool(litrosA)}");
            }

            //Ex: 6
            string[] nomes = new string[10];
            string nome;

            for(var i = 0 ; i < nomes.Length ; i++)
            {
                System.Console.WriteLine("Digite um nome: ");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("Digite um nome a ser pesquisado: ");
            nome = Console.ReadLine();

            for(var i2 = 0 ; i2 < nomes.Length ; i2++)
            {
                if( nome == nomes[i2]){
                    System.Console.WriteLine("Nome encontrado!");
                } 
            }

            //Ex: 5
            Console.WriteLine("Digite o número da tabuada desejada: ");
            int esquerda = int.Parse(Console.ReadLine());
            for(var direita = 0 ; direita <= 10 ; direita++)
            {
                int resultado = esquerda * direita; 
                Console.WriteLine($"{esquerda} x {direita} = {resultado} ");
            }

            //Ex: 3

            System.Console.WriteLine("Digite o nome do produto: ");
            string descricaoNome = Console.ReadLine();

            System.Console.WriteLine("Digite a quantidade do produto: ");
            double qtdAdqui = int.Parse(Console.ReadLine());
            double precoUnit = 5000;

            double desconto1 = 0.02 * precoUnit * qtdAdqui;
            double desconto2 = 0.03 * precoUnit * qtdAdqui;
            double desconto3 = 0.05 * precoUnit * qtdAdqui;

            double total = qtdAdqui * precoUnit;

            double totalApagar;
            if(qtdAdqui <= 5){
                 totalApagar = total - desconto1;
                 System.Console.WriteLine($"Valor total a se pagar: R${totalApagar} Reais");
            } else if(qtdAdqui > 5 && qtdAdqui <= 10){
                totalApagar = total - desconto2;
                 System.Console.WriteLine($"Valor total a se pagar: R${totalApagar} Reais");
            } else if(qtdAdqui > 10){
                totalApagar = total - desconto3;
                 System.Console.WriteLine($"Valor total a se pagar: R${totalApagar} Reais");
            }
        }
    }
}
