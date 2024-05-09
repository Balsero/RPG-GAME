using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Actions
{
    public class AttackWithWeapon
    {
        private readonly GameItem _weapon;
        private readonly int _maximumDamage;
        private readonly int _minimumDamage;

        public event EventHandler<string> OnActionPerformed;
        public AttackWithWeapon(GameItem weapon, int maximumDamage, int minimumDamage)
        {
            if(weapon.Category != GameItem.ItemCategory.Weapon)
            {
                throw new ArgumentException($"{weapon.Name} is not a weapon");
            }

            if(_minimumDamage < 0)
            {
                throw new ArgumentException("minimumDamage must be 0 or larger");
            }

            if(_maximumDamage < _minimumDamage)
            {
                throw new ArgumentException("maximumDamage must be >= minimumDamage");
            }

            _weapon = weapon;
            _maximumDamage = maximumDamage;
            _minimumDamage = minimumDamage;
        }
        public void Execute(LivingEntity attacker, LivingEntity defender)
        {
            int damage = RandomNumberGenerator.NumberBetween(_minimumDamage, _maximumDamage);

            if(damage == 0)
            {
                OnActionPerformed?.Invoke(this, $"{attacker.Name} missed {defender.Name}");
            }
            else
            {
                defender.TakeDamage(damage);
                OnActionPerformed?.Invoke(this, $"{attacker.Name} hit {defender.Name} for {damage} points");
            }
        }   
    }
}
