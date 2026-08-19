namespace HeroesVsMonster_Labo.Characters
{
    internal class Ork : Monster
    {
        public int StrengthRacialeBonus { get; } = 1;

        public Ork(Dice dice) : base(dice)
        {
        }

        public override int Strike(Dice dice)
        {
            int damage = dice.Throw();

            return CalculateStatistic(Strength + StrengthRacialeBonus, damage);
        }

        public override LootEnum Drop()
        {
            return LootEnum.gold;
        }
    }
}
