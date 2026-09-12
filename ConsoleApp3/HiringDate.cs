using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class HiringDate
    {
        public int hireDay { get; set; }
        public int hireMonth { get; set; }
        public int hireYear { get; set; }

        public HiringDate(int hireDay, int hireMonth, int hireYear)
        {
            this.hireDay = hireDay;
            this.hireMonth = hireMonth;
            this.hireYear = hireYear;
        }
        public override string ToString()
        {
            return $"{hireDay}/{hireMonth}/{hireYear}";
        }
    }
}
