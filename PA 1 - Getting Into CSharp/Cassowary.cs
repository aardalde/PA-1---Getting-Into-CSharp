// Name: Aaron Alden
// Date: 1/22/2022
// File: Cassowary.cs
/* Description: A concrete child class of Animal. This class implements all public
 * functions defined in the Animal abstract parent class.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_1___Getting_Into_CSharp
{
    public class Cassowary : Animal
    {
        public override void printInfo()
        {
            Console.WriteLine("Name: " + getSetName);
            Console.WriteLine("Age: " + getSetAge);
            Console.WriteLine("Weight: " + getSetWeight);
        }
        public override void makeNoise()
        {
            Console.WriteLine("You call out to " + getSetName + " and suddenly hear " +
                "an annoying noise off in the distance..." + getSetNoise);
        }
        public override void ageUp()
        {
            getSetAge = getSetAge + 1;
            Console.WriteLine(getSetAge);
        }
    }
}
