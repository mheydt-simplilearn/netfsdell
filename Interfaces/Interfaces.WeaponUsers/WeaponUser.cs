using Interfaces.Definitions;
using System;

namespace Interfaces.WeaponUsers
{
    public class WeaponUser : IWeaponUser
    {
        private readonly IWeapon _weapon;

        public WeaponUser(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void UseWeapon()
        {
            _weapon.Utilize();
        }
    }
}
