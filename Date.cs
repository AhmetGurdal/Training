using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a date dd/mm/yyyy");
            string sdate = Console.ReadLine();
            string[] spdate = sdate.Split("/");
            DateTime date = new DateTime(int.Parse(spdate[2]),int.Parse(spdate[1]),int.Parse(spdate[0]));
            Console.Write(date);
        }
    }
}
