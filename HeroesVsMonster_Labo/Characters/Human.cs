using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesVsMonster_Labo.Characters
{
    internal class Human : Hero
    {
        public int EnduranceRacialeBonus { get; } = 1;
        public int StrengthRacialeBonus { get; } = 1;

        public Human(Dice dice) : base(dice)
        {
            OnCalcutaleLifeEvent += CalculateStatistic;
            InvokeOnCalcutaleLifeEvent(Endurance + EnduranceRacialeBonus);
            OnCalcutaleLifeEvent -= CalculateStatistic;
        }

        public override int Strike(Dice dice)
        {
            int damage = dice.Throw();

            return CalculateStatistic(Strength + StrengthRacialeBonus, damage);
        }
    }
}
