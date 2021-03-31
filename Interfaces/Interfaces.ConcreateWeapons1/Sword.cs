using Interfaces.Definitions;
using System;

namespace Interfaces.ConcreateWeapons1
{
    public class Sword : IWeapon
    {
        public void Utilize()
        {
            Console.WriteLine("My name is Inigo Montoya, you killed my father, prepare to die!");
        }
    }
}
