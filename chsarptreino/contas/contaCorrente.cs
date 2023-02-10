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
        public static int TotalDeContasCriadas { get; set; }
        private int numero_agencia;
        //private string conta;
        //quando definimos (private) o campo só é visivel dentro da propria classe
        //classe tem que ter o principio da responsabilidade
        //estar completa para fazer o que tem que fazer
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            private set
            {
                if(value > 0)
                {
                    this.numero_agencia = value;
                }
            }
               
            
        }
        public string Conta { get; set; }
        
        private double saldo = 100;
        public cliente Titular { get; set; }
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
        public contaCorrente(int numero_agencia, string numero_conta)
        {
            this.Numero_agencia= numero_agencia;
            this.Conta = numero_conta;
            TotalDeContasCriadas++;
            //quando crio um objeto no metodo construtor ele incrementa e executa as funções desse objeto
            //o this faz refencia a instancia do objeto e por isso deve ser removido
            //totalDeContasCriadas é uma propriedade da classe e não do objeto
        }
    }
}

//Em classes, interfaces e structs, você pode adicionar o modificador static a
//campos, métodos, propriedades, operadores, eventos e construtores.
//O modificador static não pode ser usado com indexadores ou finalizadores.