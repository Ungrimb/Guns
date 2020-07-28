using System;
using System.Collections.Generic;
using System.Text;

namespace Guns
{
    class Soldado
    {

        readonly Arsenal arsenal;
        public Soldado(Arsenal arsenal)
        {
            this.arsenal = arsenal;
        }

        public void Attack(string target, IWeapon weapon)
        {
            weapon.Hit(target);
        }
    }

}
