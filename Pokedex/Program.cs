namespace PokemonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            Pokedex pokedex = new Pokedex();

            Console.WriteLine("Bem-vindo ao Batalha Pokémon");
            Console.WriteLine("Insira seu nick:");
            var namePlayer = Console.ReadLine()!;
            Console.Clear();

            int resposta = 100;
            while(resposta != 0)
            {
                resposta = Menu();
                switch(resposta)
                {
                    case 1:
                        Console.Clear();
                        pokedex.ListPokemons();
                        break;

                    case 2:
                        Console.Clear();
                        try
                        {
                            pokedex.ListPokemons();
                            Console.WriteLine("Digite o código do pokémon desejado:");
                            var cod = int.Parse(Console.ReadLine()!);
                            pokedex.GetPokemon(namePlayer, cod);
                            break;
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Houve um problema ao escolher uma das opções");
                            Console.WriteLine(ex.Message);
                            break;
                        }
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        static int Menu()
        {
            Console.WriteLine("Batalha Pokémon");
            Console.WriteLine("Opções:");
            Console.WriteLine("0 - Sair do jogo");
            Console.WriteLine("1 - Listar todos os Pokémons da pokédex");
            Console.WriteLine("2 - Batalhar");
            var resposta = short.Parse(Console.ReadLine());

            return resposta;
        }
    }
}