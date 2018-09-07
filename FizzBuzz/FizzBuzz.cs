using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public List<int> numbers { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="numbers"> accpts and sets list of numbers</param>
        public FizzBuzz(List<int> numbers)
        {
            this.numbers = numbers;
        }
        /// <summary>
        /// Inserts "fizz", "Buzz" and "FizzBuzz" strings where numbers are multiples of 3, 5 and both of them
        /// </summary>
        /// <param name="numbers"> List of numbers </param>
        /// <returns> Resturns inserted string </returns>
        public List<string> GetFizzBuzzResult()
        {
            List<string> result = new List<string>();

            foreach (int n in numbers)
            {
                if (n == 0)
                    result.Add(n.ToString());
                else if (n % 3 == 0 && n % 5 == 0)
                    result.Add("FizzBuzz");
                else if (n % 3 == 0)
                    result.Add("Fizz");
                else if (n % 5 == 0)
                    result.Add("Buzz");
                else
                    result.Add(n.ToString());
            }

            return result;
        }

        /// <summary>
        /// Function displays the list
        /// </summary>
        /// <param name="disp"> List to display </param>
        public void Display(List<string> disp)
        {
            foreach (var d in disp)
                Console.WriteLine(d);
        }
    }
}
