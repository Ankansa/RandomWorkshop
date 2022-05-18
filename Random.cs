using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWorkshop
{
    internal class Randome
    {
        public static void Randomemethod()
        {
            Random obj1 = new Random();
            int num1 = obj1.Next(1, 7);
            Console.WriteLine(num1);

        }
        

    }
}
