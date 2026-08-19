namespace HeroesVsMonster_Labo.Characters
{
    internal class Wolf : Monster
    {
        public Wolf(Dice dice) : base(dice)
        {
        }

        public override LootEnum Drop()
        {
            return LootEnum.leather;
        }
    }
}
