using Interfaces.Definitions;
using System;

namespace Interfaces.ConcreteWeapons2
{
    public class LightSaber : IWeapon
    {
        public void Utilize()
        {
            Console.WriteLine("Luke, Obi-wan never told you, I am your father");
        }
    }
}
