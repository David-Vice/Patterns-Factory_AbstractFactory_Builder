using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_HW3
{
    interface IEngineer
    {
        Car Build();
    }

    class MercedesEngineer : IEngineer
    {
        public Car Build()
        {
            return new Mercedes();
        }
    }

    class BMWEngineer : IEngineer
    {
        public Car Build()
        {
            return new BMW();
        }
    }

    abstract class Car
    {

    }

    class Mercedes : Car
    {
        public Mercedes()
        {
            Console.WriteLine("Mercedes");
        }
    }

    class BMW : Car
    {
        public BMW()
        {
            Console.WriteLine("BMW");
        }
    }
}
