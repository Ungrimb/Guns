using System;
using System.Collections.Generic;
using System.Text;

namespace Guns
{
    class Tanque
    {

        readonly Arsenal arsenal;
        public Tanque(Arsenal arsenal)
        {
            this.arsenal = arsenal;
        }

        public void Attack(string target, IWeapon weapon)
        {
            weapon.Hit(target);
        }
    }

}
