using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicio:

            Console.Clear(); //comando para limpar a tela do console

            Console.Write("Digite o  primeiro número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Escolha a operação (+ - x /): ");

            char op =  char.Parse(Console.ReadLine());
            double resultado = 0;

            switch(op){
                default:
                Console.WriteLine(); break;

                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine("O resultado da soma é: " + resultado);break;

                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine("O resultado da subtração é: "+ resultado);break;

                case 'x': case 'X': case '*':
                    resultado = num1 * num2;
                    Console.WriteLine("O resultado  da multiplicação é: "+ resultado);break;

                 case '/':
                 
                 if(num2 == 0)
                 {
                     Console.WriteLine("Não é possível dividir por zero", resultado);

                 }
                 else
                 {

                    resultado = num1 / num2;
                    Console.WriteLine("O resultado  da divisão é: ", resultado);
                 }
                 break;                    
            }
            Console.Write("Continuar calculando? (s/n)");
            string opcao = Console.ReadLine();

            if (opcao == "s" || opcao == "S")
            {
                goto Inicio;
            }            
        }
    }
}
