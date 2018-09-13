using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDate date1 = new MyDate();
            

            MyDate date2 = new MyDate(1,2,1996);

            MyDate date3 = new MyDate(03);

            date1.PrintDate();
            date2.PrintDate();
            date3.PrintDate();
            

        }
    }
}
