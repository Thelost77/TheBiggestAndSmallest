using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        private static string TheBiggestAndSmallest(string givenNumbers)
        {
            var listOfGivenNumbers = new List<int>();
            string addComponent = null;
            int i = 0;
            foreach (char c in givenNumbers)
            {
                if (c != ' ' && givenNumbers.Contains(' '))
                {
                    addComponent = addComponent + c.ToString();
                    i++;
                }

                if (c == ' ' || i == givenNumbers.Length  && givenNumbers.Contains(' '))
                {
                    listOfGivenNumbers.Add(int.Parse(addComponent));
                    addComponent = null;
                    i++;
                }
                if (!givenNumbers.Contains(' ') && givenNumbers.Length == 1)
                {
                    listOfGivenNumbers.Add(int.Parse(c.ToString()));
                    break;
                }

                if(!givenNumbers.Contains(' ') && givenNumbers.Length > 1)
                {
                    addComponent = addComponent + c.ToString();
                    i++;
                    if (i == givenNumbers.Length)
                    {
                        listOfGivenNumbers.Add(int.Parse(addComponent));
                        break;
                    }
                }
            }
            string outcome = listOfGivenNumbers.Max().ToString();
            outcome = outcome + " " + listOfGivenNumbers.Min().ToString();
            return outcome;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj, podaj mi listę liczb całkowitych oddzielonych od siebie znakiem space.");
            var numbers = Console.ReadLine();
            Console.WriteLine(TheBiggestAndSmallest(numbers));
            
        }
    }
}
