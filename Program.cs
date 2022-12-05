using consoleTeste.sistema;
using System;

namespace consoleTeste
{
    public class Program{
        public static void Main(string[] args){
            var conta = new Conta();
            conta.NomeConta = 'Conta Bancaria';
            conta.NumConta = 12345678;
            conta.Saldo = 1000;
            conta.Agencia = 304;

            conta.Titular = new Titular()  
            {
            Cpf = "12345678900",
            Rg = 987654321,
            Endereço = "Rua Central",
            Nome = "Bruno Victor"
            };

            Console.WriteLine($"Saldo atual:  { conta.VerSaldo()}");

            conta.Depositar(200);

            Console.WriteLine($"Saldo após deposito:  {conta.VerSaldo()}");

            conta.Sacar(600);

            Console.WriteLine($"Saldo após saque:  {conta.VerSaldo()}");

            Coonsole.ReadKey();


        }
    }
}

