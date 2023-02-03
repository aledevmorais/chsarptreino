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
        public void depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool sacar(double valor)
        {
            if(valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }

            this.saldo -= valor;
        }
    }
}

//Em classes, interfaces e structs, você pode adicionar o modificador static a
//campos, métodos, propriedades, operadores, eventos e construtores.
//O modificador static não pode ser usado com indexadores ou finalizadores.