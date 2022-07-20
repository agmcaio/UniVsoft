namespace RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            
        }

        public override string Attack()
        {
            return $"{this.Name} Atacou utilizando a arte ninja";
        }
    }
}