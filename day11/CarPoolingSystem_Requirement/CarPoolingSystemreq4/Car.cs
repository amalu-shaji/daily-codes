using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Req4

{

    class Cars

    {

        public abstract class Car

        {

            public long Id { get; set; }

            public string Name { get; set; }

            // Abstract method for calculating drive cost

            public abstract double CalculateDriveCost(double km);

        }

    }

}


















