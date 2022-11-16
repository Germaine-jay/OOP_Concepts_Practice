using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leap_year
{
    internal class Program
    {
        public int count;
        public List<int> yearList = new List<int>();
        public void leapYear()
        {
            while (yearList.Count != 20)
            {
                int year = 2022 + count;
                int days = DateTime.DaysInMonth(year, 2);

                if (days == 29)
                {
                    yearList.Add(year);
                }
                count++;
            }
            foreach (int year in yearList)
            {
                Console.WriteLine($"The year {year} is a leap year");
            }
        }

        static void Main(string[] args)
        {
            Program New = new Program();
            New.leapYear();
        }
    }
}
