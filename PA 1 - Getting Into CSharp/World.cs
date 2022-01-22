// Name: Aaron Alden
// Date: 1/22/2022
// File: World.cs
/* Description:
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_1___Getting_Into_CSharp
{
    public class World
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello zookeeper. Select an option from the menu: ");
            Console.WriteLine("0. Exit the program");
            Console.WriteLine("1. BLANK");
            Console.WriteLine("2. BLANK");
            Console.WriteLine("3. BLANK");
            Console.WriteLine("4. BLANK");
            //string menuChoice = Convert.ToInt32(Console.ReadLine());
           // do
            //{
                List<Animal> animalList = new List<Animal>();
                animalList.Add(new Cat("Mefdghgfhon", 6, "MEOOOOOOOOOOW", 69.69));
                Cat c = new Cat("gfhi", 6, "MEOOOOOOOOOOW", 69.69);
                c.getSetName = "Meowson";
                c.getSetNoise = "\"MEOW MEOW MEOOOOOOOOOW!\"";
                c.printInfo();
                c.makeNoise();
                c.getSetAge = 12;
                c.ageUp();
                Console.ReadKey();
            //} //while (menuChoice != 0);
        }
    }
}
