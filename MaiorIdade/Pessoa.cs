namespace MaiorIdade
{
    public class Pessoa
    {
        static List<Pessoa>? pessoas;        
        
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        private int idade;
        public int Idade
        {
            get { return idade; }
            set { 
                if (value >= 0)
                    idade = value;
                else
                    Console.WriteLine("Insira uma idade válida");
            }
        }

        public Pessoa()
        {

        }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void GetMaiorIdade(int quantPessoas)
        {
            pessoas = new List<Pessoa>();
            var maiorIdade = 0;

            for (int i = 1; i <= quantPessoas; i++)
            {
                Console.WriteLine($"Insira o nome da {i}° pessoa");
                Nome = Console.ReadLine()!;
                Console.WriteLine($"Insira a idade da {i}° pessoa");
                Idade = int.Parse(Console.ReadLine()!);

                pessoas.Add(new Pessoa()
                {
                    Nome = Nome!,
                    Idade = Idade
                });
            }

            foreach (Pessoa p in pessoas)
            {
                if (p.Idade > maiorIdade)
                {
                    var pessoaDeMaiorIdade = p.Nome;
                    maiorIdade = p.Idade;
                    Console.WriteLine();
                    Console.WriteLine($"{pessoaDeMaiorIdade} é o mais velho, tendo {maiorIdade} anos");
                }
            }
        }
    }
}
