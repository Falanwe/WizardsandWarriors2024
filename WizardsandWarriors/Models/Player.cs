using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardsandWarriors.Models
{
    public abstract class Player
    {
        public Weapon? EquippedWeapon { get; set; }
    }
}
