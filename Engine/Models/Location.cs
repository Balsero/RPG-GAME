using System.Collections.Generic;
using System.Linq;
using Engine.Factories;
namespace Engine.Models
{
     public class Location
    {
        public int XCoordinate { get; }
        public int YCoordinate { get; }
        public string Name { get; }
        public string Description { get; }

        public string ImageName { get;}

        public List<Quest> QuestsAvailableHere { get;} = new List<Quest>();
        public List<MonsterEncounter> MonstersHere { get;} =
            new List<MonsterEncounter>();

        public Trader TraderHere { get; set; }
        public Location(int xCoordinate, int yCoordinate, string name, string description, string imageName)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            Name = name;
            Description = description;
            ImageName = imageName;
        }

        public void AddMonster(int monsterID,int chanceOfEncountering)
        {
            if(MonstersHere.Exists(m => m.MonsterID == monsterID))
            {
                MonstersHere.First(m => m.MonsterID == monsterID)
                           .ChanceOfEncountering = chanceOfEncountering;
            }
            else
            {
                MonstersHere.Add(new MonsterEncounter(monsterID, chanceOfEncountering));
            }

        }

        public Monster GetMonster()
        {
            if(!MonstersHere.Any())
            {
                return null;
            }

            int totalChances = MonstersHere.Sum(m => m.ChanceOfEncountering);

            int randomNUmber = RandomNumberGenerator.NumberBetween(1, totalChances);

            int runningTotal = 0;

            foreach(MonsterEncounter monsterEncounter in MonstersHere)
            {
                runningTotal += monsterEncounter.ChanceOfEncountering;

                if(randomNUmber <= runningTotal)
                {
                    return MonsterFactory.GetMonster(monsterEncounter.MonsterID);
                } 
            }
            return MonsterFactory.GetMonster(MonstersHere.Last().MonsterID);
        }
    }
}
