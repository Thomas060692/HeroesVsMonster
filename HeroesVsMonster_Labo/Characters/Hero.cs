using HeroesVsMonster_Labo.Interface;

namespace HeroesVsMonster_Labo.Characters
{
    enum LootEnum
    {
        leather,
        gold,
        leatherAndGold
    }

    internal abstract class Hero : Character, ILoot
    {
        Inventory inventory;

        public Hero(Dice dice) : base(dice)
        {
            inventory = new Inventory();
        }

        public void Loot(Monster mob, Dice d4, Dice d6)
        {
            LootEnum loot = mob.Drop();

            switch (loot)
            {
                case LootEnum.leather:
                    inventory.Add(loot, d4.Throw());
                    break;
                
                case LootEnum.gold:
                    inventory.Add(loot, d6.Throw());
                    break;

                case LootEnum.leatherAndGold:
                    inventory.Add(LootEnum.leather, d4.Throw());
                    inventory.Add(LootEnum.gold, d6.Throw());
                    break;
            }
        }
    }
}
