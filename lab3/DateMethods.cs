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
            if (Day != null && Month != null)
            {
                Console.WriteLine(day.ToString() + ' ' + ConvertMonth(month) + ' ' + year.ToString() + " года");
            }
            else
            {
                Console.WriteLine("Дата задана неверно");
            }
        }

        private string ConvertMonth(int? month)
        {
            string strMonth = "";
            switch (month)
            {
                case 1:
                    strMonth = "Января";
                    break;
                case 2:
                    strMonth = "Февраля";
                    break;
                case 3:
                    strMonth = "Марта";
                    break;
                case 4:
                    strMonth = "Апреля";
                    break;
                case 5:
                    strMonth = "Мая";
                    break;
                case 6:
                    strMonth = "Июня";
                    break;
                case 7:
                    strMonth = "Июля";
                    break;
                case 8:
                    strMonth = "Августа";
                    break;
                case 9:
                    strMonth = "Сентября";
                    break;
                case 10:
                    strMonth = "Октября";
                    break;
                case 11:
                    strMonth = "Ноября";
                    break;
                case 12:
                    strMonth = "Декабря";
                    break;

            }

            return strMonth;
        }
    }
}
