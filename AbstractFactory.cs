using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_HW3
{
    abstract class Rifle
    {
        public Rifle(int ammo)
        {
            this.Ammo = ammo;
        }
        public int Ammo { get; set; }

        public abstract void Fire();
    }

    abstract class Knife
    {
        public Knife(int bladelength)
        {
            Bladelength = bladelength;
        }
        public int Bladelength { get; set; }

        public abstract void Stab();
    }

    class AK47 : Rifle
    {
        public AK47(int ammo) : base(ammo) { }


        public override void Fire()
        {
            Console.WriteLine("AK-47 Firing...");
        }
    }

    class M4 : Rifle
    {
        public M4(int ammo) : base(ammo) { }

        public override void Fire()
        {
            Console.WriteLine("M4 Firing...");
        }
    }


    class Bayonet : Knife
    {
        public Bayonet(int bladelength) : base(bladelength){ }
        public override void Stab()
        {
            Console.WriteLine("Bayonet Stab");
        }
    }

    class Butterfly : Knife
    {
        public Butterfly(int bladelength) : base(bladelength) { }
        public override void Stab()
        {
            Console.WriteLine("Butterfly Stab");
        }
    }


    abstract class WeaponFactories
    {
        public abstract Rifle CreateRifle(int ammo);
        public abstract Knife CreateKnife(int bladelength);

    }
    class SovietFactory : WeaponFactories
    {
        public override Rifle CreateRifle(int ammo)
        {
            return new AK47(ammo);
        }

        public override Knife CreateKnife(int bladelength)
        {
            return new Butterfly(bladelength);
        }
    }

    class USAFactory : WeaponFactories
    {
        public override Rifle CreateRifle(int ammo)
        {
            return new M4(ammo);
        }

        public override Knife CreateKnife(int bladelength)
        {
            return new Bayonet(bladelength);
        }
    }
}
