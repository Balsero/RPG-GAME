using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public class TraderFactory
    {
        private static readonly List<Trader> _traders = new List<Trader>();

        static TraderFactory()
        {
            Trader morton = new Trader("Morton the Merchant");
            morton.AddItemToInventory(ItemFactory.CreateGameItem(1001));

            Trader uncleMax = new Trader("Uncle Max the Farmer");

            Trader jasmin = new Trader("Jasmin the Herbologist");

            AddTraderToList(morton);
            AddTraderToList(uncleMax);
            AddTraderToList(jasmin);
        }
        public static Trader GetTraderByName(string name)
        {
            return _traders.FirstOrDefault(t => t.Name == name);
        }

        private static void AddTraderToList(Trader trader)
        {
            if (_traders.Any(t => t.Name == trader.Name))
            {
                throw new ArgumentException($"There is already a trader named '{trader.Name}'");
            }
            _traders.Add(trader);
        }
       
    }
}
