using System;
using System.Collections.Generic;
using System.Text;

namespace Guns
{
    class Arsenal
    {

        readonly IWeapon[] weapons = { 
        new Pistola(),
        new Rifle(),
        new Ametralladora()
        };

        public IWeapon[] GetWeapons() => weapons;

        public void AddWeapon(IWeapon weapon)
        {

            for (int i = 0; i < this.weapons.Length; i++) {
                if (this.weapons[i] == null)
                {
                    this.weapons[i] = weapon;
                    break;
                }
            }

        }

    }
}
