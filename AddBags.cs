using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddBags
{
    internal class AddBags
    {
        static void Main(string[] args)
        {
            //zad. 2

            Console.Write("Enter the price of the luggage over 20kg: ");
            var priceover20kg = int.Parse(Console.ReadLine());
            Console.Write("Enter the weight of the luggage: ");
            int weightoftheluggage = int.Parse(Console.ReadLine());
            Console.Write("Enter days before the flight: ");
            int daybeforetheflight = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of bags: ");
            int numberofbags = int.Parse(Console.ReadLine());

            var total = 0.0;

            if(weightoftheluggage < 10)
            {
                var weight10 = priceover20kg * 0.2;
                if(daybeforetheflight > 30)
                {
                    var tax3010 = weight10 * 0.1;
                    var newweight10 = weight10 + tax3010;
                    total = newweight10 * numberofbags;
                }
                else if(daybeforetheflight >= 7 && daybeforetheflight <= 30)
                {
                    var tax710 = weight10 * 0.15;
                    var newweight10 = weight10 + tax710;
                    total = newweight10 * numberofbags;
                }
                else if(daybeforetheflight < 7)
                {
                    var taxunder7 = weight10 * 0.4;
                    var newweight10 = weight10 + taxunder7;
                    total = newweight10 * numberofbags;
                }
            }
            else if(weightoftheluggage >= 10 && weightoftheluggage <= 20)
            {
                var weight20 = priceover20kg * 0.5;
                if (daybeforetheflight > 30)
                {
                    var tax3020 = weight20 * 0.1;
                    var newweight20 = weight20 + tax3020;
                    total = newweight20 * numberofbags;
                }
                else if (daybeforetheflight >= 7 && daybeforetheflight <= 30)
                {
                    var tax720 = weight20 * 0.15;
                    var newweight20 = weight20 + tax720;
                    total = newweight20 * numberofbags;
                }
                else if (daybeforetheflight < 7)
                {
                    var taxunder7 = weight20 * 0.4;
                    var newweight20 = weight20 + taxunder7;
                    total = newweight20 * numberofbags;
                }

                Console.WriteLine($"The total price of bags is {total:F2} lv.");
            }
        }
    }
}
