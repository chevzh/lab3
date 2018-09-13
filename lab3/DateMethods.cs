using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public partial class MyDate
    {
        public void PrintDate()
        {
            if (Day != 0 && Month != 0)
            {
                Console.WriteLine(day.ToString() + ' ' + months.ElementAt(month-1) + ' ' + year.ToString() + " года");
            }
            else
            {
                Console.WriteLine("Дата задана неверно");
            }
        }

      

        
    }
}
