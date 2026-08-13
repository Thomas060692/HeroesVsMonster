namespace HeroesVsMonster_Labo.Characters
{
    internal class Nain : Hero
    {
        public int EnduranceRacialeBonus { get; } = 2;

        public Nain(Dice dice) : base(dice)
        {
            OnCalcutaleLifeEvent += CalculateStatistic;
            InvokeOnCalcutaleLifeEvent(Endurance + EnduranceRacialeBonus);
            OnCalcutaleLifeEvent -= CalculateStatistic;
        }
    }
}
