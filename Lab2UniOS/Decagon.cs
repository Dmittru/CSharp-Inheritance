﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Decagon : Figure
    {
        public double Side { get; set; }

        public double Radius { get; set; }

        public override double GetArea()
        {
            return Side * Radius * 0.5 * 10;
            throw new NotImplementedException();
        }

    }
}
