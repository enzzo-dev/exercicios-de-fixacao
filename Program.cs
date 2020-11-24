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
                double aDesc1 =  desconto1 * alcool * a;
                double aDesc2 = desconto2 * alcool * a;
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
                double desconto1 = 0.04 ;
                double desconto2 = 0.06;
                double aDesc1 = desconto1 * gasolina * b;
                double aDesc2 = desconto2 * gasolina * b;
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

            //Ex: 4
                int[] numeros = new int[10];
                int menorNum = 0 , maiorNum = 0;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("======================================= Digite 10 valores: ================================================");
                Console.ResetColor();

                for(var i4 = 0 ; i4 < numeros.Length ; i4++)
                {
                    Console.WriteLine($"Digite o {i4 + 1}° número: ");
                    numeros[i4] = int.Parse(Console.ReadLine());

                    menorNum = numeros[0];
                    if(numeros[i4] < menorNum)
                    {
                        menorNum = numeros[i4];
                    } else if(numeros[i4] > maiorNum)
                    {
                        maiorNum = numeros[i4];
                    }

                }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O maior número declarado é: {maiorNum}");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O menor número declarado é: {menorNum}");
                    Console.ResetColor();

            //Ex: 5
            Console.WriteLine("Digite o número da tabuada desejada: ");
            int esquerda = int.Parse(Console.ReadLine());
            for(var direita = 0 ; direita <= 10 ; direita++)
            {
                int resultado = esquerda * direita; 
                Console.WriteLine($"{esquerda} x {direita} = {resultado} ");
            }

            //Ex: 6
            string[] nomes = new string[10];
            string nome;

            for(var i5 = 0 ; i5 < nomes.Length ; i5++)
            {
                System.Console.WriteLine("Digite um nome: ");
                nomes[i5] = Console.ReadLine();
            }

            Console.WriteLine("Digite um nome a ser pesquisado: ");
            nome = Console.ReadLine();

            for(var i6 = 0 ; i6 < nomes.Length ; i6++)
            {
                if( nome == nomes[i6]){
                    System.Console.WriteLine("Nome encontrado!");
                } 
            }

            //Ex: 7

            int[] numbers = new int[15];
            for(var i7 = 0 ; i7 < 15 ; i7++)
            {
                Console.WriteLine($"Escreva um número: ");
                numbers[i7] = int.Parse(Console.ReadLine());
            }

            for( var i8 = 15 ; i8 > 1 ; i8--)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Ordem de forma invertida da qual foi declarada: {numbers[i8 - 1]}");
                Console.ResetColor();
            }
        }
    }
}
