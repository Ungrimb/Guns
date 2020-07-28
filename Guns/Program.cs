using System;

namespace Guns
{
    class Program
    {
        public static void Main()
        {
            var arsenal = new Arsenal();
            var weapons = arsenal.GetWeapons();
            var soldier1 = new Soldado(new Arsenal());
            var soldier2 = new Soldado(new Arsenal());
            soldier1.Attack("soldado2", weapons[0]);
            soldier2.Attack("soldado1", weapons[1]);
        }
    }
}
