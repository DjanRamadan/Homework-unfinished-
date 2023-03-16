using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeAgency
{
    internal class IncomeAgency
    {
        static void Main(string[] args)
        {
            //zad. 1

            Console.Write("Enter the name of the airline: ");
            var airline = Console.ReadLine();
            Console.Write("Enter the amount of adult tickets: ");
            int adulttickets = int.Parse(Console.ReadLine());
            Console.Write("Enter the amount of kid tickets: ");
            int kidtickets = int.Parse(Console.ReadLine());
            Console.Write("Enter net price for 1 adult ticket: ");
            var netpriceadult = int.Parse(Console.ReadLine());
            var seventy = netpriceadult * 0.7;
            var netpricekid = netpriceadult - seventy;
            Console.Write("Enter service tax: ");
            int servicetax = int.Parse(Console.ReadLine());

            var adultafterservice = netpriceadult + servicetax;
            var kidafterservice = netpricekid + servicetax;

            var adulttotal = adultafterservice * adulttickets;
            var kidtotal = kidafterservice * kidtickets;
            var totaltickets = adulttotal + kidtotal;

            var profit = totaltickets * 0.2;
            Console.WriteLine($"Your profit of your agency from {airline} tickets is {profit:F2} lv.");
        }
    }
}
