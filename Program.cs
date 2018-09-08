using System;
using System.Collections.Generic;

//Using the Random class, generate a list of 20 random numbers that are in the range of 1-50.

//Random random = new Random();
//// Create a list
//// Populate the list
//With the resulting List, populate a new List that contains each number squared.For example, if the original list is 2, 5, 3, 15, the final list will be 4, 25, 9, 225.

//Then remove any number that is odd from the list of squared numbers.

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a list
            var rand = new Random();
            List<int> numberList = new List<int>();
            List<int> squaredList = new List<int>();

            // populate list with random number
            for (var i = 0; i < 20; i++)
            {
                numberList.Add(rand.Next(1, 51));
            }

            // print original list
            string originalNumbers = "";
            foreach (var number in numberList)
            {
                originalNumbers += number + ",";
            }

            var trimedOriginalNumbers = originalNumbers.TrimEnd(',');
            Console.WriteLine("Original List: " + trimedOriginalNumbers);

            // square elements in the list
            foreach (var number in numberList)
            {
                var sqauredValue = number * number;
                if (sqauredValue % 2 == 0)
                {
                    squaredList.Add(sqauredValue);
                }
            }

            // print sqaured list
            string squaredNumbers = "";
            foreach (var squaredNumber in squaredList)
            {
                squaredNumbers += squaredNumber + ",";
            }

            var trimedSquaredNumbers = squaredNumbers.TrimEnd(',');
            Console.WriteLine("Squared List without Odd Numbers: " + trimedSquaredNumbers);
        }
    }
}
