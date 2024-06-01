using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageHalla
{
    public class LeechSeed: ISpell
    {
        public void Cast(Mage caster, Mage target)
        {
            Random rand = new Random();
            int damage = rand.Next(16, 38);
            string type = "Earth";
            target.GetDamaged(damage, type);
            Console.WriteLine($"{caster.Name} throws leech seeds on {target.Name} and deals {damage} dmg.");
            caster.OnSpellCast(caster, target, damage);
            System.Threading.Thread.Sleep(500);
        }
    }
}
