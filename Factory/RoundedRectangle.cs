﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory
{
    public class RoundedRectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rounded rectangle");
        }
    }
}
