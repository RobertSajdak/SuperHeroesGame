namespace SuperHeroesGame
{
    class Wizard : Hero, ISpecialAttack
    {
        public Wizard(string name, int fullhp, Colors color) : base(name, fullhp, color)
        {
        }

        public override void DefaultAttack(Hero hero)
        {
            int hp = rnd.Next(100, 151);
            hero.ActualHP -= hp;
            Console.WriteLine($"\nGracz {Name} zadał {hp} punktów obrażeń graczowi {hero.Name}.");
        }

        public override void Heal()
        {
            int hp = rnd.Next(100, 201);
            ActualHP += hp;
            Console.WriteLine($"\nGracz {Name} uzdrowił się za {hp} punktów życia.");
        }

        public void SpecialAttack(Hero hero)
        {
            int hp = rnd.Next(250, 301); 

            hero.ActualHP -= hp;
            Console.WriteLine($"\nAtak Specjalny! Gracz {Name} zadał {hp} punktów obrażeń graczowi {hero.Name}.");
        }
    }
}
