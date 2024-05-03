using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static List<GameItem> _standardGameItems;
        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new Weapon(1001, "Pointy Stick", 1, 1, 2));
            _standardGameItems.Add(new Weapon(1002, "Rusty Sword", 5, 1, 3));
            _standardGameItems.Add(new GameItem(9001, "Snake fang", 1));
            _standardGameItems.Add(new GameItem(9002, "Snakeskin", 2));
        }
        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);
            if (standardItem != null)
            {
                return standardItem.Clone();
            }
            return null;
        }
    }
}