using consoleTeste.sistema;
using System;

namespace consoleTeste
{
    public class program{
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

            Console.WriteLine("Saldo atual: ", conta.VerSaldo());
        }
    }
}

