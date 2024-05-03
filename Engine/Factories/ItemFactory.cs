using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static readonly List<GameItem> _standardGameItems;

        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new Weapon(1001, "Pointy Stick", 1, 0, 2));
            _standardGameItems.Add(new Weapon(1002, "Rusty Sword", 5, 5, 10));
            _standardGameItems.Add(new GameItem(9001, "Snake fang", 1));
            _standardGameItems.Add(new GameItem(9002, "Snakeskin", 2));
            _standardGameItems.Add(new GameItem(9003, "Rat tail", 1));
            _standardGameItems.Add(new GameItem(9004, "Rat fur", 2));
            _standardGameItems.Add(new GameItem(9005, "Spider fang", 1));
            _standardGameItems.Add(new GameItem(9006, "Spider silk", 2));
        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);

            if (standardItem != null)
            {
                if (standardItem is Weapon)
                {
                    return (standardItem as Weapon).Clone();
                }
                return standardItem.Clone();
            }

            return null;
        }   

    }
}
