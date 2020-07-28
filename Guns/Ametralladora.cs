using System;
using System.Collections.Generic;
using System.Text;

namespace Guns
{
    class Ametralladora : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine("Acribillas a {0}.",target);
        }

    }
}
