namespace MaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Insira a quantidade de pessoas que você deseja comparar as idades:");
            var quantPessoas = int.Parse(Console.ReadLine()!);
            pessoa.GetMaiorIdade(quantPessoas);
        }
    }
}

