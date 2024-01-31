using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class CarFactory
    {
        public static IOrderable OrderCar(string choice)
        {
            switch (choice)
            {
                case "Subaru":
                    return new Subaru();
                case "Toyota":
                    return new Toyota();
                default:
                    return new Toyota();
            }
        }
    }
}
