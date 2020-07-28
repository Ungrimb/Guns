using System;
using System.Collections.Generic;
using System.Text;

namespace Guns
{
    class Pistola : IWeapon
    {

        public void Hit(string target)
        {
            Console.WriteLine("Tu Pistola dispara a {0}", target);
        }

    }
}
