using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using static Req4.Cars;

using System.Xml.Linq;

namespace Req4

{

    internal class UtilityCar_class

    {

        // UtilityCar class

        public class UtilityCar : Car

        {

            public bool RearCoolingVents { get; set; }

            // Constructor

            public UtilityCar(long id, string name, bool rearCoolingVents)

            {

                Id = id;

                Name = name;

                RearCoolingVents = rearCoolingVents;

            }

            // Implementing abstract method from Car class

            public override double CalculateDriveCost(double km)

            {

                return 18 * km;

            }

        }

    }
}




