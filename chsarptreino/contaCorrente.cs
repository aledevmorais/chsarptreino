using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptreino
{
    public class contaCorrente
    {
        public int numero_agencia;
        public string conta;
        public string titular;
        public double saldo = 100;
    }
    public void depositar(double valor)
    {
        this.saldo += valor;
    }

    public void sacar(double valor)
    {
        this.saldo -= valor;
    }
}
