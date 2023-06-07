using System;
using System.Globalization;

namespace Banco2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = Char.Parse(Console.ReadLine());
            
            if (resp == 's' || resp == 'S') // Caso tenha um depósito inicial, inicia o construtor com o valor a ser depositado no saldo.
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else // Caso nao tenha deposito inicial, só executa o numero da conta e o titular.
            {
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            
            Console.Write("Entre um valor para saque: ");
            quantia = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            
        }
    }
}