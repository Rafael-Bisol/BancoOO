using System;
using System.Reflection;

namespace BancoOO_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá senhor!\nBem-vindo ao Banco FDP!");
            
            Console.Write("Para criar sua conta primeiro conte-nos seu nome:\n> ");
            // Conta conta1 = new Conta(Console.ReadLine());
            string nome = Console.ReadLine();

            Console.Write("Digite o número inicial da conta:\n> ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Deseja fazer um depósito inicial? (S/N)\n> ");
            string resposta = Console.ReadLine();

            double deposito = 0;

            if (resposta.StartsWith('S') || resposta.StartsWith('s'))
            {
                Console.Write("Digite o valor do deposito inicial:\n> ");
                deposito = double.Parse(Console.ReadLine());
            }
            Conta conta1 = new Conta(nome, deposito, numConta);
            Console.WriteLine($"Seu saldo é: {conta1.Saldo:c}");

            Console.Write("Por favor, faça um depósito:\n> ");
            deposito = double.Parse(Console.ReadLine());
            conta1.Deposito(deposito);

            Console.WriteLine($"Seu saldo é {conta1.Saldo:c}");
            
            Console.Write("Faça um saque (atente-se: há uma taxa de R$5,00 por saque):\n> ");
            conta1.Saque(double.Parse(Console.ReadLine()));

            Console.WriteLine($"Seu saldo atualizado é {conta1.Saldo:c}");
        }
    }
}
