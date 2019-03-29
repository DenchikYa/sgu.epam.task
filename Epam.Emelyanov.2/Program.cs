using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Emelyanov._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee test = new Employee("Den", "Den", "Den", new DateTime(1978, 7, 17), "20", "13", "student");
            Ring test2 = new Ring(new Point(1, 2), 3, 10);
            Console.WriteLine(test2.SumCircumferenceRadius);
            Console.WriteLine(test2.ShowRing());
        }
    }
}
