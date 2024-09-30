using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Loops
{
    public class ForeachLoop
    {
        public void Main()
        {
            int[] array = { 1, 2, 5, 6, 7, 8, 9 };
            int sum = 0;

            foreach (int item in array)
            {
                sum = sum + item;
            }

            Console.WriteLine(sum);
        }
    }
}
