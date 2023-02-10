using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace csharptreino.titular
{
    public class cliente
    {
        //public string nome;
        //public string cpf;
        //public string profissão;
        //escreva prop e pressione tab 2 vezes a ide vai criar public int MyProperty { get; set; } padrao
        // ele cria um espoco de propriedade auto implementada
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        // propriedades publicas que irão manipular campos privados em tempo de execução
    }
}
