﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class Toyota : IOrderable
    {
        public void Description()
        {
            Console.WriteLine("The best parts for a sports car");
        }
    }
}
