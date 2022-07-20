namespace PokemonApp
{
    public class PokemonPower : Pokemon
    {
        public PokemonPower() : base()
        {
            Power = 0;
        }
        public PokemonPower(string name, string type, string description, int power) : base(name, type, description)
        {
            Power = power;
        }
        public int Power { get; set; }

        public void DisplayDataWithPower()
        {
            Console.WriteLine($"{Power} - {Name} - {Type}: {Description}");
        }
    }
}
