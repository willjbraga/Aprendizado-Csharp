using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Seção_5 {
    public class Conta {
        public int Numero {  get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; set; }

        public Conta(int numero, string titular, double saldo) {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public Conta(int numero, string titular) {
            this.Numero = numero;
            this.Titular = titular;
            Saldo = 0;
        }

        public void Deposito(double valor) {
            Saldo += valor;
        }

        public void Saque(double valor) {
            Saldo -= valor + 5 ; 
        }

        public override string ToString() {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
