using System;
using System.Collections.Generic;
using System.Text;

namespace Guns
{
    class Rifle : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine("Tu Rifle perfora a {0}", target);
        }

    }
}
