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
        public string getSetName
        {
            get { return Name; }
            set { Name = value; }
        }
        public int getSetAge
        {
            get { return Age; }
            set { Age = value; }
        }
        public string getSetNoise
        {
            get { return Noise; }
            set { Noise = value; }
        }
        public double getSetWeight
        {
            get { return Weight; }
            set { Weight = value; }
        }
        public abstract void printInfo();
        public abstract void makeNoise();
        public abstract void ageUp();
    }
}
