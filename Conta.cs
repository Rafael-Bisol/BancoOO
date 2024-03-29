using System;
using System.Diagnostics.CodeAnalysis;

namespace BancoOO_aula
{
    class Conta
    {
        private string _nome;
        public double Saldo{get; private set;}
        public int NumeroConta{get; private set;}

        public Conta(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome) || nome.Length < 3)
            {
                Console.WriteLine("Nome é vazio ou muito pequeno.");
                return;
            }
            _nome = nome;
            Saldo = 0;
            NumeroConta = 0;
        }

        public Conta(string nome, double depositoInicial) : this(nome)
        {
            if (depositoInicial < 0)
            {
                Console.WriteLine("O depósito inicial não pode ser negativo.");
                return;
            }
            Saldo = depositoInicial;
            NumeroConta = 0;
        }

        public Conta(string nome, double depositoInicial, int numConta) : this(nome, depositoInicial)
        {
            if (numConta < 0 || numConta.ToString().Length > 4)
            {
                Console.WriteLine("O número da conta não pode ser negativo.");
                return;
            }
            NumeroConta = numConta;
        }


        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    Console.WriteLine("Nome é vazio ou muito pequeno.");
                    return;
                }
                _nome = value;
            }
        }
        
        public void Deposito(double val) // Deposit
        {
            if (val <= 0)
            {
                Console.WriteLine("O depósito não pode ser negativo!");
                return;
            }
            Saldo += val;
        }

        public void Saque(double val) // Withdraw
        {
            if (val <= 0)
            {
                Console.WriteLine("O saque não pode ser negativo!");
                return;
            }
            if (val > Saldo)
            {
                Console.WriteLine("O saque não pode ser maior que o saldo!");
                return;
            }
            Saldo -= val + 5;
        }
    }
}