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
           Console.WriteLine(day.ToString() + ' ' + months.ElementAt(month-1) + ' ' + year.ToString() + " года");  
        }

      
        private void SetDate()
        {
            try
            {
                Console.WriteLine("Введите число");
                Day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите месяц");
                Month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите год");
                Year = Convert.ToInt32(Console.ReadLine());
            }

            catch (FormatException)
            {
                Console.WriteLine("Проверьте правильность данных и введите их снова");
                SetDate();
            }
        }
        
    }
}
