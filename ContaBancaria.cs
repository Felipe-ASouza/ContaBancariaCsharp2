using System.Globalization;

namespace Banco2
{
    public class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }
        public string TitularConta { get; set; }
        public double Saldo { get; private set; }
        
        //Instanciar construtores e ToString, haverá dois construtores. Um com o saldo, caso o demonio faça o deposito inicial
        // e outro caso nao tenha deposito  
        public ContaBancaria(int numero, string titular) //Construtor que recebe apenas o Numero da conta e o Titular
        {
            NumeroDaConta = numero;
            TitularConta = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) //Construtor que recebe numero, titular e saldo.
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                   + NumeroDaConta
                   + ", "
                   + "Titular: "
                   + TitularConta
                   + ", Saldo: $ "
                   + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}