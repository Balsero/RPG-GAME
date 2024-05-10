using System.Collections.ObjectModel;
namespace Engine.Models
{
    public class Monster : LivingEntity
    {
        public string ImageName { get;}

        public int RewardExperiencePoints { get;}

        public Monster(string name, string imageName,
                       int maximumHitPoints, int currentHitPoints,
                       int rewardExperiencePoints, int gold) :
            base(name, maximumHitPoints, currentHitPoints, gold)
        {
            Name = name;
            ImageName = $"/Engine;component/Images/Monster/{imageName}";
            RewardExperiencePoints = rewardExperiencePoints; 


        }

    }
}
