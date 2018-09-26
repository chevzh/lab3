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

            MyDate date4 = new MyDate(4, 5, 1996);

            MyDate date5 = new MyDate(3,8,1234);

            date1.SetDate();

            date1.PrintDate();
            date2.PrintDate();
            date3.PrintShortDate();

            int value = 2;
            int constant;
            Console.WriteLine("Сумма числа и константы равна " + MyDate.GetSum(ref value, out constant));

            MyDate.GetClassInfo();
            Console.WriteLine("Id третьего объекта : " + date3.Id);

            Console.WriteLine(date2.Equals(date3));


            MyDate[] dates = new MyDate[] {date1,date2,date3,date4,date5};

            Console.WriteLine("Список дат 1996го года:");
            foreach (MyDate date in dates)
            {
                if(date.Year == 1996)
                {
                    date.PrintShortDate();
                }
            }

            Console.WriteLine("Список дат с номером дня 3:");
            foreach (MyDate date in dates)
            {
                if (date.Day == 3)
                {
                    date.PrintShortDate();
                }
            }

            var anonDate = new { Day = 01, Month = 02, Year = 2077 }; // анонимный тип

        }
    }
}
