using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Loops
{
    public class ForLoop
    {
        public void Main()
        {
            int n = 7;
            int sum = 0;

            for(int i = 1; i <= n; i++)
            {
                sum+= i;
            }
            Console.WriteLine(sum);
        }
    }
}
