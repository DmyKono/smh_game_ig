using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageHalla
{
    public class Claw: ISpell
    {
        public void Cast(Mage caster, Mage target)
        {
            Random rand = new Random();
            int damage = rand.Next(8, 19);
            string type = "Physical";
            target.GetDamaged(damage, type);
            Console.WriteLine($"{caster.Name} кидає кам'яний зсув в {target.Name} і завдає {damage} ушкодження.");
            caster.OnSpellCast(caster, target, damage);
        }
    }
}
