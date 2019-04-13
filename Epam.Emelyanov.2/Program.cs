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
            streamFile file = new streamFile();
            Employee[] arrEmployee = file.Read();
            file.Write(arrEmployee);

            Ring test2 = new Ring(new Point(1, 2), 10, 3);
            Console.WriteLine(test2.SumCircumferenceRadius);
            Console.WriteLine(test2.ShowRing());
        }
    }
}
