using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate Numbers
            List<int> numbers = Enumerable.Range(0, 100).ToList<int>();

            // Pass Numbers in the processor class
            FizzBuzz fb = new FizzBuzz(numbers);

            // Generate Result
            List<string> display = fb.GetFizzBuzzResult();

            // Display Result
            fb.Display(display);

            // Stop console for character
            Console.ReadKey();
        }
    }
}
