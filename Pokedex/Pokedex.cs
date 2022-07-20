namespace PokemonApp
{
    public class Pokedex
    {
        public Pokedex()
        {
            initializeList();
        }

        private List<PokemonPower> pokemons;

        public List<PokemonPower> Pokemons
        {
            get { return pokemons; } // Apenas obter os dados e não inseri-los
        }

        private void initializeList()
        {
            // Instanciando lista
            pokemons = new List<PokemonPower>();
            PokemonPower pokemon = new PokemonPower("Charizard", "Fogo", "Pokémon do tipo fogo", 80);
            pokemons.Add(pokemon);
            pokemon = new PokemonPower("Bulbasauro", "Planta", "Pokémon do tipo planta", 75);
            pokemons.Add(pokemon);
            pokemon = new PokemonPower("Pikachu", "Elétrico", "Pokémon do tipo elétrico", 85);
            pokemons.Add(pokemon);
            pokemon = new PokemonPower("Squirtle", "Água", "Pokémon do tipo água", 75);
            pokemons.Add(pokemon);
        }

        public void ListPokemons()
        {
            var contador = 0;
            foreach (Pokemon p in pokemons)
            {
                Console.WriteLine("Código do pokémon: {0}", contador);
                pokemons[contador].DisplayDataWithPower();
                contador++;
            }
        }

        public void GetPokemon(string name, int codigo)
        {
            // Obter pokemon do player
            PokemonPower player = pokemons[codigo];

            // Definir pokemon do pc
            Random r = new Random();
            var codigoPC = r.Next(0, pokemons.Count);
            PokemonPower pc = pokemons[codigoPC];

            Console.Clear();
            Console.WriteLine("Carta escolhida pelo player {0}:", name);
            pokemons[codigo].DisplayDataWithPower();

            Console.WriteLine("Carta escolhida pelo computador:");
            pokemons[codigoPC].DisplayDataWithPower();

            Console.ReadLine();

            // Batalhar
            if (player.Power > pc.Power)
                Console.WriteLine("Vitória de {0}", name);
            else if (player.Power == pc.Power)
                Console.WriteLine("Batalha empatada");
            else
                Console.WriteLine("Derrota para {0}", name);
        }
    }
}
