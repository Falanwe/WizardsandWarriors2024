using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardsandWarriors.Models
{
    class Wizard : Player
    {
        public new Staff? EquippedWeapon
        {
            get => (Staff?)base.EquippedWeapon;
            set => base.EquippedWeapon = value;
        }
    }
}
