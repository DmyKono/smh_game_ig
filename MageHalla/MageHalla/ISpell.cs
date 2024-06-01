using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageHalla
{
    public interface ISpell
    {
        void Cast(Mage caster, Mage target);
    }

}
