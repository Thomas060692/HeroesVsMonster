namespace HeroesVsMonster_Labo.Characters
{
    internal class Wyrmling : Monster
    {
        public int EnduranceRacialeBonus { get; } = 1;

        public Wyrmling(Dice dice) : base(dice)
        {
            OnCalcutaleLifeEvent += CalculateStatistic;
            InvokeOnCalcutaleLifeEvent(Endurance + EnduranceRacialeBonus);
            OnCalcutaleLifeEvent -= CalculateStatistic;
        }

        public override LootEnum Drop()
        {
            return LootEnum.leatherAndGold;
        }
    }
}
