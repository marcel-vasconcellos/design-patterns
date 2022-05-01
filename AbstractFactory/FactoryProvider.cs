﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class FactoryProvider
    {
        public static IAnimalFactory GetAnimalFactory(string factoryType)
        {
            if (factoryType.Contains("wild"))
            {
                return new WildAnimalFactory();
            }
            else if (factoryType.Contains("pet"))
            {
                return new PetAnimalFactory();
            }
            else
            {
                throw new ArgumentException("You need to pass either wild or pet as argument");
            }
        }
    }
}
