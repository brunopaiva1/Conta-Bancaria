using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Task;

namespace consoleTeste.sistema
{
    public class Conta
    {
        public int Agencia {get ; set;}
        public int NumConta {get; set;}
        public string NomeConta {get; set;}
        public Titular Titular {get; set;}
        public Decimal Saldo {get; set;}
        public Decimal VerSaldo(){
            return Saldo;
        }
        public void Depositar(decimal valor){
            Saldo += valor;
        }
        public void Sacar(decimal valor){
            Saldo -= valor;
        }
        
    }
    
}