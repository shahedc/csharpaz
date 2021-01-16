using bitLib;
using System;

namespace bit_netcore31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from .NET Core 3.1!");

            // show weapons defined
            Console.WriteLine("Weapons defined: knife, pistol, sword, stick, shotgun");

            // create weapon bag
            int myWeaponBag;
            Console.WriteLine("Initiating weapon bag...");

            // store weapons in bag
            myWeaponBag = StoreWeaponsInBag();

            // check for weapons
            LookForWeapons(myWeaponBag);

        }

        private static void LookForWeapons(int myWeaponBag)
        {
            Console.WriteLine("Looking for weapons...");
            ShowWeaponFound(myWeaponBag, Weapons.Knife, nameof(Weapons.Knife));
            ShowWeaponFound(myWeaponBag, Weapons.Pistol, nameof(Weapons.Pistol));
            ShowWeaponFound(myWeaponBag, Weapons.Sword, nameof(Weapons.Sword));
            ShowWeaponFound(myWeaponBag, Weapons.Stick, nameof(Weapons.Stick));
            ShowWeaponFound(myWeaponBag, Weapons.Shotgun, nameof(Weapons.Shotgun));

        }

        private static void ShowWeaponFound(int weaponBag, int weapon, string weaponName)
        {            
            Console.WriteLine((weaponBag & weapon) > 0 
                ? $"--> Found {weaponName}" : $"NO {weaponName}");
        }

        private static int StoreWeaponsInBag()
        {
            int myWeaponBag;
            Console.WriteLine("Storing a few weapons in bag (knife, pistol, stick)...");
            myWeaponBag = Weapons.Knife | Weapons.Pistol | Weapons.Stick;
            return myWeaponBag;
        }
    }
}
