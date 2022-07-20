namespace RPG.src.Entities
{
    public class Wizard : Hero
    {
        // O método construtor, AQUI, pode ser vazio
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType) 
        {

        }

        public override string Attack()
        {
            return $"{this.Name!} Lançou magia "; 
        }

        public override string Attack(int Bonus)
        {
            // Encapsulamento
            if (HeroType == "White Wizard" && Bonus > 5){
                return $"{this.Name} Lançou magia com bonus de ataque de {Bonus} "; 
            } 
            else if (HeroType == "Black Wizard" && Bonus > 5) 
            {
                return $"{this.Name!} Lançou magia negra com bonus de ataque de {Bonus} "; 
            }
            else
                return $"{this.Name} Lançou magia fraca com bonus de {Bonus}"; 
            
        }
    }
}