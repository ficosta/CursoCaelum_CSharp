namespace BancoCaelum
{
   
        public class Cliente
        {
            public string Nome { get; set; }
            public string CPF { get; set; }
            public int Idade { get; set; }

            public Cliente(string nome, string cpf, int idade) // metodo construtor onde nome, cpf e idade são obrigatórios
            {
                this.Nome = nome;
                this.CPF = cpf;
                this.Idade = idade;
            }

            public Cliente(string nome, string cpf) // metodo construtor nome cpf obrigatório e idade opcional sem prejudicar os projetos que são obrigatório
            {
                this.Nome = nome;
                this.CPF = cpf;

            }

            public Cliente() { } // metodo construtor as informações são opcionais sem prejudicar outros projetos que são obrigatório

        
          
        public Cliente(string nome)
        {
            Nome = nome;
        }
    }
    }
