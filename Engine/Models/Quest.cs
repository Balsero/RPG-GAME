using System;
using System.Collections.Generic;
using System.Linq;

namespace Engine.Models
{
    public class Quest
    {
        public int ID { get;}
        public string Name { get;}
        public string Description { get;}
        public List<ItemQuantity> ItemsToComplete { get;}
        public int RewardExperiencePoints { get;}
        public int RewardGold { get; set; }
        public List<ItemQuantity> RewardItems { get; }
        public Quest(int id, string name, string description, List<ItemQuantity> itemsToComplete,
                     int rewardExperiencePoints, int rewardGold, List<ItemQuantity> rewardItems)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemsToComplete = itemsToComplete;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            RewardItems = rewardItems;
        }
    }
}
