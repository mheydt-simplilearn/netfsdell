using Interfaces.ConcreateWeapons1;
using Interfaces.ConcreteWeapons2;
using Interfaces.Definitions;
using Interfaces.WeaponUsers;
using Ninject;
using System;

namespace Interfaces.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Bind<IWeaponUser>().To<WeaponUser>().InSingletonScope();
            kernel.Bind<IWeapon>().To<Sword>();


            var user = kernel.Get<IWeaponUser>();

            /*
            var user = new WeaponUser(new Sword());
            */
            user.UseWeapon();
        }
    }
}
