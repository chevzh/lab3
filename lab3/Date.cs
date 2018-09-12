using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public partial class MyDate
    {
        private int? day;
        private int year;
        private int? month;
        
        
        
        
        public  int? Day
        { get => day;
          set
            {
                if(value >0 && value <= 31)
                {
                    day = value;
                }
                else
                {
                    Console.WriteLine("Задайте день числом от 0 до 31");
                }
            }
        }

        public int? Month
        { get => month;
          set
            { 
                if(value > 0 && value <= 12)
                {
                    month = value;
                }
                else
                {
                    Console.WriteLine("Задайте месяц в пределах 1-12");
                }
            }
        }

        public int Year
        {
            get => year;
            set
            {
                if(value.GetType() == typeof(int))
                {
                    year = value;
                }
                else 
                {
                    Console.WriteLine("Год должен быть задан целым числом");
                }
            }
        }


        public MyDate(int day) // с параметрами по умолчанию
        {
            Day = day;
            Month = 04;
            Year = 1984;
        }

        public MyDate(int day, int month, int year) // с параметрами
        {
            Day = day;
            Month = month;
            Year = year;
        }

        private MyDate(string value) // конструктор без параметров
        {
            Console.WriteLine(value);
        }

        public MyDate()
        {

        }       

        static MyDate() // статический конструктор
        {
            Console.WriteLine("Йо собаки");
            MyDate date = new MyDate("Я Наруто Узумаки");
        }


       
    }
}
