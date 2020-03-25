using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    delegate bool theDelegate(int n);

    class Controller
    {
        public void MainMethod()
        {
            int[] numberSet = new[] { 1, 5, 9, 13, 17, 21, 33 };

            Console.WriteLine("\n Here is your number set.");
            Console.Write("\n\t");
            foreach (int num in numberSet)
                Console.Write(num + " ");

            Console.WriteLine("\n\n We will use lambda expressions to pick out certain variables!");
            Console.WriteLine("\n Lets start with all numbers that are less than 10!");
            Console.Write("\n\t");
            IEnumerable<int> result = SortNumbers(numberSet, n => n < 10);

            foreach (int n in result)
                Console.Write(n + " ");

            Console.WriteLine("\n\n Now we will sort numbers greater than 10 but less than 20");
            Console.Write("\n\t");
            result = SortNumbers(numberSet, n => n > 10 && n < 20);

            foreach (int n in result)
                Console.Write(n + " ");

            Console.WriteLine("\n\n Finally we will sort numbers greater than 20");
            Console.Write("\n\t");
            result = SortNumbers(numberSet, n => n > 20);

            foreach (int n in result)
                Console.Write(n + " ");

            Console.WriteLine("\n\n Press Enter to exit!");

            Console.ReadLine();
        }

        public IEnumerable<int> SortNumbers(IEnumerable<int> numberSet, theDelegate del)
        {
            foreach (int num in numberSet)
                if (del(num))
                    yield return num;
        }
    }
}
