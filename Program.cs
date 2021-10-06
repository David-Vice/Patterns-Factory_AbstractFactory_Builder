using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IEngineer engineer = new MercedesEngineer();
            //Car car = engineer.Build();

            //WeaponFactories factory = new SovietFactory();
            //Knife myknife = factory.CreateKnife(9);
            //myknife.Stab();

            Patterns2_HW3.BuilderFullCustom myRifle = new Patterns2_HW3.BuilderFullCustom();
            myRifle.Build();
        }
    }
}
