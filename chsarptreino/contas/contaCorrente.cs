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
        private int numero_agencia;
        //private string conta;
        public string Conta
        {
            get; set;
        }
        private double saldo = 100;
        //quando definimos (private) o campo só é visivel dentro da propria classe
        //classe tem que ter o principio da responsabilidade
        //estar completa para fazer o que tem que fazer
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            set { this.numero_agencia= value; }
            //quando eu chamo set eu acesso variavel//
            //criamos uma propriedade que é publica "Numero_agencia" para manipular o campo "numero_agencia"
            //como a propriedade tem scopo {} nós podemos manipular por funções
        }
        private cliente titular;

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
        public bool transferir(double valor, contaCorrente destino)
        {
            if(saldo < valor)
            {
                return false;
            }
            else
            {
                sacar(valor);
                destino.depositar(valor);
                return true;

            }
        }
        public void SetSaldo(double valor)
        {
            if( valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }
        public double GetSaldo()
        {
            return this.saldo;
        }
    }
}

//Em classes, interfaces e structs, você pode adicionar o modificador static a
//campos, métodos, propriedades, operadores, eventos e construtores.
//O modificador static não pode ser usado com indexadores ou finalizadores.