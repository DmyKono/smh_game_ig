using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageHalla
{
    public class FireBreath: ISpell
    {
        public void Cast(Mage caster, Mage target)
        {
            Random rand = new Random();
            int damage = rand.Next(16, 38);
            string type = "Fire";
            target.GetDamaged(damage, type);
            Console.WriteLine($"{caster.Name} spits some fire on the {target.Name} and deals {damage} dmg.");
            caster.OnSpellCast(caster, target, damage);
            System.Threading.Thread.Sleep(500);
        }
    }
}
