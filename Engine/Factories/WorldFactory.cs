using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {   
            World newWorld = new World();

            newWorld.AddLocation(0, -1, "Home","Home sweet home.", "/Engine;component/Images/Locations/Home.png");
            newWorld.AddLocation(-1, -1, "Farmer's House ", "This is the house of your uncle Max." + "\n" + "He is a farmer and he is your neighbor." + "\n" + "Come and say hello.", "/Engine;component/Images/Locations/Farmhouse.png");
            newWorld.AddLocation(-2, -1, "Farmer's Field", "This is the field of your uncle Max." + "\n" + "Hmm, the tomatoes look delicious! ","/Engine;component/Images/Locations/FarmFields.png");
            newWorld.AddLocation(-1, 0, "Trading Shop", "This is the trading shop of Morton." + "\n" + "Look at him! He’s very busy.", "/Engine;component/Images/Locations/Trader.png");
            newWorld.AddLocation(0, 0, "Town square", "This is the town square." + "\n" + "This is the most emblematic place of the town." + "\n" + " This is where the party goes on!", "/Engine;component/Images/Locations/TownSquare.png");
            newWorld.AddLocation(1, 0, "Town Gate", "There is a gate here, protecting the town from giant spiders.", "/Engine;component/Images/Locations/TownGate.png");
            newWorld.AddLocation(2, 0, "Spider Forest", "This is the forbidden spider forest." + "\n" + " What happens to you if you go there is your own business." + "\n" + " Go back!", "/Engine;component/Images/Locations/SpiderForest.png");
            newWorld.AddLocation(0, 1, 
                "Herbalist's Hut", "This is the herbalist's hut." + "\n" + " She is a very nice lady." + "\n" + 
                " She can help you with your wounds.", "/Engine;component/Images/Locations/HerbalistsHut.png");
            
            newWorld.LocationAt(0,1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));
            
            newWorld.AddLocation(0, 2, "Herbalist's Garden", "This is the herbalist's garden." + "\n" + " Pay attention where you step on!", "/Engine;component/Images/Locations/HerbalistsGarden.png");

            return newWorld;

        }
    }
}
