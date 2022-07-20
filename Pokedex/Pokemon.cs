namespace PokemonApp
{
    public class Pokemon
    {
        public Pokemon()
        {

        }
        public Pokemon(string name, string type ,string description)
        {
            Name = name;
            Type = type;
            Description = description;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value.ToUpper(); }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value.ToUpper(); }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value.ToUpper(); }
        }

        public void DisplayData()
        {
            Console.WriteLine($"{Name}, {Type}: {Description}");
        }
    }
}
