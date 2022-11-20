using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leap_year
{
    internal class Program
    {
        private int count;
        private List<int> yearList = new List<int>();
        public void leapYear()
        {
            while (yearList.Count != 20)
            {
                int Year = 2022 + count;
                int Days = DateTime.DaysInMonth(Year, 2);

                if (Days == 29)
                {
                    yearList.Add(Year);
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
