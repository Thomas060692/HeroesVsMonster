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
            OnCalcutaleLifeEvent += CalculateLife;
            InvokeOnCalcutaleLifeEvent(Endurance + EnduranceRacialeBonus);
            OnCalcutaleLifeEvent -= CalculateLife;
        }

        public override int Strike(Dice dice)
        {
            throw new NotImplementedException();
        }
    }
}
