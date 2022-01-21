// Name: 
// Date:
// File:
/* Description:
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
       public Animal(string name, int age, string noise, double weight)
        {
            Name = name;
            Age = age;
            Noise = noise;
            Weight = weight;
        } 
        public abstract void printInfo();
        public abstract void makeNoise();
        public abstract void ageUp();
    }
}
