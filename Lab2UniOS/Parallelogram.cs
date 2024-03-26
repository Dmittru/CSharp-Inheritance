using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Parallelogram : Figure
    {
        public double Side { get; set; }
        public double Height { get; set; }


        public override double GetArea()
        {
            return Side * Height;
            throw new NotImplementedException();
        }

    }
}
