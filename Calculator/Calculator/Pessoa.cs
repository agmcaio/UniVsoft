namespace Calculadora
{
    public class Pessoa
    {
        public Pessoa(String nome, int anoNascimento)
        {
            this.Nome = nome;
            this.AnoNascimento = anoNascimento;
            this.CalcularIdade();
        }

        public string? nome; // variável que vai armazenar o valor da propriedade
        public string Nome // Propriedade
        {
            get { return this.nome!; }
            set { this.nome = value; }
        }

        private int anoNascimento;
        public int AnoNascimento
        {
            get { return this.anoNascimento; }
            set { this.anoNascimento = value; }
        }

        private int idade;
        public int Idade
        {
            get
            {
                this.CalcularIdade();
                return this.idade;
            }
        }

        // Criando ação de cálculo da idade
        private DateTime data => DateTime.Now;
        private void CalcularIdade()
        {
            this.idade = this.data.Year - this.anoNascimento;
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: {0}", this.Nome);
            Console.WriteLine("Ano de nascimento: {0}", this.AnoNascimento);
            this.CalcularIdade();
            Console.WriteLine("Idade: {0}", this.Idade);
        }
    }
}
