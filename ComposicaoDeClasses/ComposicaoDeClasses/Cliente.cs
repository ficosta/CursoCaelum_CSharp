using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoDeClasses
{
    class Cliente
    {
        public int rg;
        public int cpf;
        public string nome;
        public int idade;
        public bool EhMaiorDeIdade()
        {
           return idade >= 18 ?  true :  false;
        }
    }
 
}
