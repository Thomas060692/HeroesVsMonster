using HeroesVsMonster_Labo.Characters;

namespace HeroesVsMonster_Labo
{
    internal class Inventory
    {
        public Dictionary<LootEnum, int> _Inventory { get; private set; }

        public Inventory()
        {
            _Inventory = new();
        }

        public void Add(LootEnum loot, int amount)
        {
            if (_Inventory.ContainsKey(loot))
            {
                _Inventory[loot] += amount;
            }
            else
            {
                _Inventory.Add(loot, amount);
            }
        }
    }
}
