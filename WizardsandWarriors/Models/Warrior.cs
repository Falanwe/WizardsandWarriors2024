﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardsandWarriors.Models
{
    public class Warrior : Player
    {
        public new Sword? EquippedWeapon
        {
            get => (Sword?)base.EquippedWeapon;
            set => base.EquippedWeapon = value;
        }
    }
}
