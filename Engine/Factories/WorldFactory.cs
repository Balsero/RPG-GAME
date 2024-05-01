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

            newWorld.AddLocation(0, -1, "Home","Home sweet home.", "Home.png");
            newWorld.AddLocation(-1, -1, "Farmer's House ", "This is the house of your uncle Max." + "\n" + "He is a farmer and he is your neighbor." + "\n" + "Come and say hello.", "Farmhouse.png");
            newWorld.AddLocation(-2, -1, "Farmer's Field", "This is the field of your uncle Max." + "\n" + "There are rows of corn growing here, with giant rats hiding between them.", "FarmFields.png");
            newWorld.LocationAt(-2, -1).AddMonster(2, 100);
            newWorld.AddLocation(-1, 0, "Trading Shop", "This is the trading shop of Morton." + "\n" + "Look at him! He’s very busy.", "Trader.png");

            newWorld.AddLocation(0, 0, "Town square", "This is the town square." + "\n" + "This is the most emblematic place of the town." + "\n" + " This is where the party goes on!", "TownSquare.png");
            newWorld.AddLocation(1, 0, "Town Gate", "There is a gate here, protecting the town from giant spiders.", "TownGate.png");
            newWorld.AddLocation(2, 0, "Spider Forest", "This is the forbidden spider forest." + "\n" + " What happens to you if you go there is your own business." + "\n" + " Go back!", "SpiderForest.png");
            newWorld.LocationAt(2, 0).AddMonster(3, 100);
            newWorld.AddLocation(0, 1, 
                "Herbalist's Hut", "This is the herbalist's hut." + "\n" + " She is a very nice lady." + "\n" + 
                " She can help you with your wounds.", "HerbalistsHut.png");
            
            newWorld.LocationAt(0,1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));
            newWorld.AddLocation(0, 2, "Herbalist's Garden", "This is the herbalist's garden." + "\n" + " Pay attention where you step on they are snakes hiding behind plants!", "HerbalistsGarden.png");
            newWorld.LocationAt(0, 2).AddMonster(1, 100);
            return newWorld;

        }
    }
}
