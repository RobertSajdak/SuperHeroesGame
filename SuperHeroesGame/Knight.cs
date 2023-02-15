namespace SuperHeroesGame
{
    class Knight : Hero
    {
        public Knight(string name, int fullhp, Colors color) : base(name, fullhp, color)
        {
        }

        public override void DefaultAttack(Hero hero)
        {
            int hp = rnd.Next(50, 201);
            hero.ActualHP -= hp;
            Console.WriteLine($"\nGracz {Name} zadał {hp} punktów obrażeń graczowi {hero.Name}.");
        }

        public override void Heal()
        {
            int hp = rnd.Next(50, 101);
            ActualHP += hp;
            Console.WriteLine($"\nGracz {Name} uzdrowił się za {hp} punktów życia.");
        }
    }
}
