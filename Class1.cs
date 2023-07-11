using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public void listOfBikes()
        {
            var listOfBikes = new List<string>()
            {
            "1. Kawasaki Z1000R ",
            "2. 2023 Kawasaki Z H2",
            "3. Ducati Panigale V4",
            "4. 2023 Honda CB650r",
            "5. 2023 Suzuki Hayabusa"
            };
            foreach (string i in listOfBikes)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*****************");

        }

        public void caseOne() 
        {
            var caseOne = new List<string>()
            {
            "Kawasaki Z1000R:",
            "   - Liquid Cooled",
            "   - In-line Four",
            "   - 1043cc",
            "   - 142 HP @ 10,000 rpm",
            "   - 6-Speed manual transmission",
            "   - 17L Fuel Capacity",
            "   - SRP: Php 710,000 "
            };
            foreach (string i in caseOne)
            {
                Console.WriteLine(i);
            }
        }
        public void caseTwo() 
        {
            var caseTwo = new List<string>()
            {
            "2023 Kawasaki Z H2",
            "   - Liquid Cooled",
            "   - In-line Four",
            "   - 998cc",
            "   - 197.4 HP @ 11,000 rpm",
            "   - 6-Speed manual transmission",
            "   - 19L Fuel Capacity",
            "   - SRP: Php 920,000 "
            };
            foreach (string i in caseTwo)
            {
                Console.Write(i);
            }
        }

        public void caseThree() 
        {
            var caseThree = new List<string>()
            { "Ducati Panigale V4",
              "   - Liquid Cooled",
              "   - V4 Engine",
              "   - 1103cc",
              "   - 215.5 HP @ 13,000 rpm",
              "   - 6-Speed manual transmission",
              "   - 16L Fuel Capacity",
              "   - SRP: Php 1,990,000 "
            };
            foreach (string i in caseThree)
            {
                Console.Write(i);
            }
        }
        public void caseFour() 
        {
            var caseFour = new List<string>()
            { "2023 Honda CB650r",
              "   - Liquid Cooled",
              "   - In-line Four",
              "   - 649cc",
              "   - 94HP @ 12,000 rpm",
              "   - 6-Speed manual transmission",
              "   - 15.4L Fuel Capacity",
              "   - SRP: Php 519,000 "
            };
            foreach (string i in caseFour)
            {
                Console.WriteLine(i);
            }
        }
        public void caseFive() 
        {
            var caseFive = new List<string>()
            {
             "2023 Suzuki Hayabusa",
             "   - Liquid Cooled",
             "   - In-line Four",
             "   - 1340cc", "   - 187HP @ 9,700 rpm",
             "   - 6-Speed manual transmission",
             "   - 20L Fuel Capacity",
             "   - SRP: Php 1,199,000 "
            };
            foreach (string i in caseFive)
            {
                Console.WriteLine(i);
            }
        }
    }
}
