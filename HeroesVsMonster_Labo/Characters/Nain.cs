namespace HeroesVsMonster_Labo.Characters
{
    internal class Nain : Hero
    {
        private int EnduranceRacialeBonus = 2;

        public Nain(Dice dice) : base(dice)
        {
        }

        public override int Strike(Dice dice)
        {
            int damage = dice.Throw();

            damage = CalculateStatistic(Strength);

            return damage;
        }
    }
}
