﻿using System.Globalization;


namespace Exercicio_Seção_5 {
    public class ContaBancaria {
        public int Numero {  get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) {
            Deposito(depositoInicial);
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
