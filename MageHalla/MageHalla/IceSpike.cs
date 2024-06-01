using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageHalla
{
    public class IceSpike: ISpell
    {
        public void Cast(Mage caster, Mage target)
        {
            Random rand = new Random();
            int damage = rand.Next(16, 38);
            string type = "Water";
            target.GetDamaged(damage, type);
            Console.WriteLine($"{caster.Name} summons the ice spikes from the ground {target.Name} and deals {damage} dmg.");
            caster.OnSpellCast(caster, target, damage);
            System.Threading.Thread.Sleep(500);
        }
    }
}
