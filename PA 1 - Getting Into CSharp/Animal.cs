// Name: Aaron Alden
// Date: 1/22/2022
// File: Animal.cs
/* Description: The abstract parent class of this application. This file declares all 
 * private data members and public functions.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_1___Getting_Into_CSharp
{
    public abstract class Animal
    {
        private
        string Name;
        int Age;
        string Noise;
        double Weight;

        /* Type: public string
         * 
         * Purpose: a get-set function that gives all child classes
         * access to the private data member variable "Name"
         * 
         * What it returns: String Name
         */
         
        public string getSetName
        {
            get { return Name; }
            set { Name = value; }
        }

        /* Type: public int
         * 
         * Purpose: a get-set function that gives all child classes
         * and World class access to the private data member variable "Age"
         * 
         * What it returns: int Age
         */
        public int getSetAge
        {
            get { return Age; }
            set { Age = value; }
        }

        /* Type: public string
         * 
         * Purpose: a get-set function that gives all child classes
         * and World class access to the private data member variable "Noise"
         * 
         * What it returns: String Noise
         */
        public string getSetNoise
        {
            get { return Noise; }
            set { Noise = value; }
        }
        /* Type: public double
         * 
         * Purpose: a get-set function that gives all child classes
         * and World class access to the private data member variable "Weight"
         * 
         * What it returns: double Weight
         */
        public double getSetWeight
        {
            get { return Weight; }
            set { Weight = value; }
        }

        /* Type: public abstract void
         * 
         * Purpose: An abstract function prototype that is implemented
         * in all 3 children classes
         * 
         * What it returns: N/A
         */
        public abstract void printInfo();

        /* Type: public abstract void
         * 
         * Purpose: An abstract function prototype that is implemented
         * in all 3 children classes
         * 
         * What it returns: N/A
         */
        public abstract void makeNoise();

        /* Type: public abstract void
         * 
         * Purpose: An abstract function prototype that is implemented
         * in all 3 children classes
         * 
         * What it returns: N/A
         */
        public abstract void ageUp();
    }
}
