namespace RPG.src.Entities
{
    public abstract class Hero
    {
        // Método Construtor
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Hero() // Um método construtor vazio para não ser obrigatório passada de parâmetro
        {

        }

        // Propriedades
        public string? Name { get; set; }
        public int Level { get; set; }
        public string? HeroType { get; set; }

        // Métodos
        public override string ToString()
        {
            return $"Nome: {this.Name}\nLevel: {this.Level}\nType: {this.HeroType} ";
        }

        public virtual string Attack()
        {
            return $"{this.Name} Atacou";
        }

        public virtual string Attack(int Bonus)
        {
            if (Bonus > 5)
                return $"{this.Name} Atacou com poder elevado a {Bonus}";
            else
                return $"{this.Name} Atacou normalmente com {Bonus} decimal poder";
        }
    }
}