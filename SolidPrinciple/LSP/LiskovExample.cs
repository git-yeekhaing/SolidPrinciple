﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.LSP
{
    class LiskovExample
    {
    }

    public abstract class Fruit
    {
        public abstract string GetColor();
    }

    public class Apple2 : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }        
    }

    public class Orange2 : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
