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
        /* Type: public override void 
         * 
         * Purpose: Assigns all private data member variables from the
         * parent class Animal equal to the Cassowary information found from the user.
         * Prints out all information (except noise) to the user.
         * 
         * What it returns: N/A
         */
        public override void printInfo()
        {
            Console.WriteLine("Name: " + getSetName);
            Console.WriteLine("Age: " + getSetAge);
            Console.WriteLine("Weight: " + getSetWeight);
        }

        /* Type: public override void 
         * 
         * Purpose: If the user wishes to hear the Cassowary's noise, this
         * function will have the animal call back to the user
         * 
         * What it returns: N/A
         */
        public override void makeNoise()
        {
            Console.WriteLine("You call out to " + getSetName + " and suddenly hear " +
                "an annoying noise off in the distance..." + getSetNoise);
        }

        /* Type: public override void
         * 
         * Purpose: Allows the user to increment the Cassowary's age by
         * 1 year then print out the new age
         * 
         * What it returns: N/A
         */
        public override void ageUp()
        {
            getSetAge = getSetAge + 1;
            Console.WriteLine(getSetAge);
        }
    }
}
