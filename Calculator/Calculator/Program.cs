namespace Calculadora
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira seu nome: ");
            string nome = Console.ReadLine()!.Trim(); // Atribuindo valor a propriedade
            Console.Write(nome + ", insira seu ano de nascimento: ");
            int ano = int.Parse(Console.ReadLine()!);

            Pessoa pessoa = new Pessoa(nome, ano);
            pessoa.ExibirDados();
        }
    }
}