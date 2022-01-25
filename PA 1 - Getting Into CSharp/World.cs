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
            int menuChoice;
            List<Animal> animalList = new List<Animal>();
            do
            {
                Console.WriteLine("0. Exit the program");
                Console.WriteLine("1. Add a new Cat and interact with it");
                Console.WriteLine("2. Add a new Elephant and interact with it");
                Console.WriteLine("3. Add a new Cassowary and interact with it");
                menuChoice = Convert.ToInt32(Console.ReadLine());
                if (menuChoice == 1)
                {
                    Cat c = new Cat();
                    Console.WriteLine("Add the new Cat's information now: ");
                    Console.WriteLine("Enter the Cat's name: ");
                    c.getSetName = Console.ReadLine();
                    Console.WriteLine("Enter the Cat's age: ");
                    c.getSetAge = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Cat's animal noise: ");
                    c.getSetNoise = Console.ReadLine();
                    Console.WriteLine("Enter the Cat's weight: ");
                    c.getSetWeight = Convert.ToDouble(Console.ReadLine());
                    animalList.Add(c);
                    Console.WriteLine();
                    Console.WriteLine("New Cat's information");
                    Console.WriteLine("==============================");
                    c.printInfo();
                    Console.WriteLine();
                    Console.WriteLine("Would you like to call out to the new Cat (type yes)?");
                    string noiseChoice = Console.ReadLine();
                    if (noiseChoice == "Yes" || noiseChoice == "yes")
                    {
                        c.makeNoise();
                    }
                    Console.WriteLine("Would you like to increment the Cat's age by 1 year (type yes)?");
                    string ageChoice = Console.ReadLine();
                    if (ageChoice == "Yes" || ageChoice == "yes")
                    {
                        c.ageUp();
                    }
                    Console.WriteLine();
                }
                else if (menuChoice == 2)
                {
                    Console.WriteLine("Add the new Elephant's information now: ");
                    Elephant e = new Elephant();
                    Console.WriteLine("Enter the Elephant's name: ");
                    e.getSetName = Console.ReadLine();
                    Console.WriteLine("Enter the Elephant's age: ");
                    e.getSetAge = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Elephant's animal noise: ");
                    e.getSetNoise = Console.ReadLine();
                    Console.WriteLine("Enter the Elephant's weight: ");
                    e.getSetWeight = Convert.ToDouble(Console.ReadLine());
                    animalList.Add(e);
                    Console.WriteLine();
                    Console.WriteLine("New Elephant's information");
                    Console.WriteLine("==============================");
                    e.printInfo();
                    Console.WriteLine();
                    Console.WriteLine("Would you like to call out to the new Elephant (type yes or no)?");
                    string noiseChoice = Console.ReadLine();
                    if (noiseChoice == "Yes" || noiseChoice == "yes")
                    {
                        e.makeNoise();
                    }
                    Console.WriteLine("Would you like to increment the Elephant's age by 1 year (type yes)?");
                    string ageChoice = Console.ReadLine();
                    if (ageChoice == "Yes" || ageChoice == "yes")
                    {
                        e.ageUp();
                    }
                    Console.WriteLine();
                }
                else if (menuChoice == 3)
                {
                    Console.WriteLine("Add the new Cassowary's information now: ");
                    Cassowary ca = new Cassowary();
                    Console.WriteLine("Enter the Cassowary's name: ");
                    ca.getSetName = Console.ReadLine();
                    Console.WriteLine("Enter the Cassowary's age: ");
                    ca.getSetAge = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Cassowary's animal noise: ");
                    ca.getSetNoise = Console.ReadLine();
                    Console.WriteLine("Enter the Cassowary's weight: ");
                    ca.getSetWeight = Convert.ToDouble(Console.ReadLine());
                    animalList.Add(ca);
                    Console.WriteLine();
                    Console.WriteLine("New Cassowary's information");
                    Console.WriteLine("==============================");
                    ca.printInfo();
                    Console.WriteLine();
                    Console.WriteLine("Would you like to call out to the new Cassowary (type yes)?");
                    string noiseChoice = Console.ReadLine();
                    if (noiseChoice == "Yes" || noiseChoice == "yes")
                    {
                        ca.makeNoise();
                    }
                    Console.WriteLine("Would you like to increment the Cassowary's age by 1 year (type yes)?");
                    string ageChoice = Console.ReadLine();
                    if (ageChoice == "Yes" || ageChoice == "yes")
                    {
                        ca.ageUp();
                    }
                    Console.WriteLine();
                }
            
        } while (menuChoice != 0);
        }
    }
}
