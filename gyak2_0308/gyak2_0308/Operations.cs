using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak2_0308
{
    public static class Operations
    {
        public static void ToConsole<T>(this IEnumerable<T> enumerable, string header)
        {
            Console.WriteLine("**** " + header + " START ****");
            foreach (var name in enumerable)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("**** " + header + " FINISH ****");
            Console.ReadLine();
        }
    }
}
