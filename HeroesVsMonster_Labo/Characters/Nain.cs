namespace HeroesVsMonster_Labo.Characters
{
    internal class Nain : Hero
    {
        public int EnduranceRacialeBonus { get; } = 2;

        public Nain(Dice dice) : base(dice)
        {
            OnCalcutaleLifeEvent += CalculateLife;
            InvokeOnCalcutaleLifeEvent(Endurance + EnduranceRacialeBonus);
            OnCalcutaleLifeEvent -= CalculateLife;
        }

        public override int Strike(Dice dice)
        {
            int damage = dice.Throw();

           // damage += CalculateStatistic(Strength);

            return damage;
        }
    }
}
