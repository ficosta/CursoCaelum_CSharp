namespace EncapsulamentoBanco
{
    public class Cliente
    {
        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }

    }

}