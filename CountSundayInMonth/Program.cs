using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSundayInMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            var result2 = GetFirstDayOfWeek(DateTime.Now.AddDays(1));


            var result = CountSundayInMonth(DateTime.Now, DateTime.Now.AddDays(30));
            Console.WriteLine(result.Count);
            Console.ReadLine();
        }
        /// <summary>
        /// Dem so ngay chu nhat trong khoan thoi gian truyen vao
        /// </summary>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <returns></returns>
        public static List<DateTime> CountSundayInMonth(DateTime dateFrom, DateTime dateTo)
        {
            List<DateTime> result = new List<DateTime>();
            while (dateFrom <= dateTo)
            {
                if (dateFrom.DayOfWeek == DayOfWeek.Sunday)
                    result.Add(dateFrom);
                dateFrom = dateFrom.AddDays(1);
            }
            return result;
        }
        /// <summary>
        /// Tra ve ngay dau tuan theo ngay truyen vao
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime GetFirstDayOfWeek(DateTime date)
        {
            DateTime result = date;
            while (result.DayOfWeek != DayOfWeek.Monday)
            {
                result = result.AddDays(-1);
            }
            return result;
        }
        /// <summary>
        /// Tra ve ngay cuoi tuan theo ngay truyen vao
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime GetLastDayOfWeek(DateTime date)
        {
            DateTime result = date;
            while (result.DayOfWeek != DayOfWeek.Sunday)
            {
                result = result.AddDays(1);
            }
            return result;
        }

    }
}
