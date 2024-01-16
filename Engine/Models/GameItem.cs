using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public GameItem(int itemID, string name, int price)
        {
            ItemID = itemID;
            Name = name;
            Price = price;
        }
        public GameItem Clone()
        {
            return new GameItem(ItemID, Name, Price);
        }
    }
}
