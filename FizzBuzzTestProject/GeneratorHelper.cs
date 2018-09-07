using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTestProject
{
    /// <summary>
    /// Generates different sequence of numbers
    /// </summary>
    public static class GeneratorHelper
    {
        /// <summary>
        /// Generate multiple of three
        /// </summary>
        /// <param name="numLimit"> Parameters for amount of numbers generated</param>
        /// <returns> Returns list of numbers multiple of three </returns>
        public static List<int> GenerateMultiplesofOnlyThree(int numLimit = 10)
        {
            List<int> result = new List<int>();
            for (int i = 1; result.Count() < numLimit; i++)
            {
                if (i % 3 == 0 && !(i % 5 == 0))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        /// <summary>
        /// Generates multiple of five
        /// </summary>
        /// <param name="numLimit"> Amount of numbers to be generated </param>
        /// <returns>List of numbers which are multiple of five</returns>
        public static List<int> GenerateMultiplesofOnlyFive(int numLimit = 10)
        {
            List<int> result = new List<int>();
            for (int i = 1; result.Count() < numLimit; i++)
            {
                if (i % 5 == 0 && !(i % 3 == 0))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        /// <summary>
        /// Generates numbers which are multiple of 3 and 5 
        /// </summary>
        /// <param name="numLimit"> </param>
        /// <returns> Returns list of numbers which are multiple of 3 and 5</returns>
        public static List<int> GenerateMultipleofThreeAndFive(int numLimit = 10)
        {
            List<int> result = new List<int>();
            for (int i = 1; result.Count() < numLimit; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        /// <summary>
        /// Generates numbers which are multiples of neither 3 and neither 5
        /// </summary>
        /// <param name="numLimit"> limits amout of numbers </param>
        /// <returns> Returns list which are multiples of neither 3 and neither 5</returns>
        public static List<int> GenerateMultipleofNeitherThreeAndNorFive(int numLimit = 10)
        {
            List<int> result = new List<int>();
            for (int i = 1; result.Count() < numLimit; i++)
            {
                if (!(i % 5 == 0) && !(i % 3 == 0))
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
