using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharptreino.titular;
//automaticamente o VS adicionou o nomespace para ser utilizado nesta classe

namespace csharptreino.contas
{
    public class contaCorrente
    {
        public int numero_agencia;
        public string conta;
        public double saldo = 100;
        //classe tem que ter o principio da responsabilidade
        //estar completa para fazer o que tem que fazer
        public cliente titular;

        public void depositar(double valor)
        {
            saldo += valor;
        }

        public bool sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }

            saldo -= valor;
        }
    }
}

//Em classes, interfaces e structs, você pode adicionar o modificador static a
//campos, métodos, propriedades, operadores, eventos e construtores.
//O modificador static não pode ser usado com indexadores ou finalizadores.