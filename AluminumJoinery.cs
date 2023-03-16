using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluminumJoinery
{
    internal class AluminumJoinery
    {
        static void Main(string[] args)
        {
            //zad. 3

            Console.Write("Enter amount of joineries: ");
            int joineries = int.Parse(Console.ReadLine());
            Console.Write("Enter the type of joinery: ");
            var typeofjoinery = Console.ReadLine();
            Console.Write("Enter shipment method: ");
            var shipmentmethod = Console.ReadLine();
            var delivery = 60;
            var discount99 = 0.04;
            var price = 0.0;
            var total = 0.0;
            var totalafterdiscount = 0.0;

            if (typeofjoinery == "90x130")
            {
                price = 110;
                if (joineries > 30 && joineries <= 60)
                {
                    total = joineries * price;
                    totalafterdiscount = total * 0.5;
                    if (shipmentmethod == "with delivery")
                    {
                        totalafterdiscount = totalafterdiscount + delivery;
                    }
                    else if (shipmentmethod == "without delivery")
                    {
                        totalafterdiscount = totalafterdiscount;
                    }
                }
                else if (joineries > 60 && joineries <= 99)
                {
                    total = joineries * price;
                    totalafterdiscount = total * 0.8;
                    if (shipmentmethod == "with delivery")
                    {
                        totalafterdiscount = totalafterdiscount + delivery;
                    }
                    else if (shipmentmethod == "without delivery")
                    {
                        totalafterdiscount = totalafterdiscount;
                    }
                }
                else if (joineries >= 10 && joineries <= 30)
                {
                    total = joineries * price;
                    totalafterdiscount = total;
                    if (shipmentmethod == "with delivery")
                    {
                        totalafterdiscount = totalafterdiscount + delivery;
                    }
                    else if (shipmentmethod == "without delivery")
                    {
                        totalafterdiscount = totalafterdiscount;
                    }
                }
                else if (joineries < 10)
                {
                    Console.WriteLine("Invalid order.");
                }
                else if (joineries > 99)
                {
                    total = joineries * price;
                    totalafterdiscount = total * 0.8;
                    if (shipmentmethod == "with delivery")
                    {
                        totalafterdiscount = totalafterdiscount + delivery;
                        totalafterdiscount = totalafterdiscount * discount99;
                    }
                    else if (shipmentmethod == "without delivery")
                    {
                        totalafterdiscount = totalafterdiscount;
                    }
                }
            }
            else if (typeofjoinery == "100x150")
            {
                price = 140;
                if (joineries > 40 && joineries <= 80)
                {
                    total = joineries * price;
                    totalafterdiscount = total * 0.6;
                    if (shipmentmethod == "with delivery")
                    {
                        totalafterdiscount = totalafterdiscount + delivery;
                    }
                    else if (shipmentmethod == "without delivery")
                    {
                        totalafterdiscount = totalafterdiscount;
                    }
                }
                else if (joineries > 80 & joineries <= 99)
                {
                    total = joineries * price;
                    totalafterdiscount = total * 0.10;
                    if (shipmentmethod == "with delivery")
                    {
                        totalafterdiscount = totalafterdiscount + delivery;
                    }
                    else if (shipmentmethod == "without delivery")
                    {
                        totalafterdiscount = totalafterdiscount;
                    }
                }
                else if (joineries >= 10 && joineries <= 40)
                {
                    total = joineries * price;
                    totalafterdiscount = total;
                    if (shipmentmethod == "with delivery")
                    {
                        totalafterdiscount = totalafterdiscount + delivery;
                    }
                    else if (shipmentmethod == "without delivery")
                    {
                        totalafterdiscount = totalafterdiscount;
                    }
                }
                else if (joineries < 10)
                {
                    Console.WriteLine("Invalid order.");
                }
                else if (joineries > 99)
                {
                    total = joineries * price;
                    totalafterdiscount = total * 0.8;
                    if (shipmentmethod == "with delivery")
                    {
                        totalafterdiscount = totalafterdiscount + delivery;
                        totalafterdiscount = totalafterdiscount * discount99;
                    }
                    else if (shipmentmethod == "without delivery")
                    {
                        totalafterdiscount = totalafterdiscount;
                    }
                }
            }
            else if (typeofjoinery == "130x180")
            {
                price = 190;
                if (joineries > 20 && joineries <= 50)
                {
                    total = joineries * price;
                    totalafterdiscount = total * 0.7;
                    if (shipmentmethod == "with delivery")
                    {
                        totalafterdiscount = totalafterdiscount + delivery;
                    }
                    else if (shipmentmethod == "without delivery")
                    {
                        totalafterdiscount = totalafterdiscount;
                    }
                }
                else if (joineries > 50 && joineries <= 99)
                {
                    total = joineries * price;
                    totalafterdiscount = total * 0.12;
                    if (shipmentmethod == "with delivery")
                    {
                        totalafterdiscount = totalafterdiscount + delivery;
                    }
                    else if (shipmentmethod == "without delivery")
                    {
                        totalafterdiscount = totalafterdiscount;
                    }
                }
                else if (joineries >= 10 && joineries <= 20)
                {
                    total = joineries * price;
                    totalafterdiscount = total;
                    if (shipmentmethod == "with delivery")
                    {
                        totalafterdiscount = totalafterdiscount + delivery;
                    }
                    else if (shipmentmethod == "without delivery")
                    {
                        totalafterdiscount = totalafterdiscount;
                    }
                }
                else if (joineries < 10)
                {
                    Console.WriteLine("Invalid order.");
                }
                else if (joineries > 99)
                {
                    total = joineries * price;
                    totalafterdiscount = total * 0.8;
                    if (shipmentmethod == "with delivery")
                    {
                        totalafterdiscount = totalafterdiscount + delivery;
                        totalafterdiscount = totalafterdiscount * discount99;
                    }
                    else if (shipmentmethod == "without delivery")
                    {
                        totalafterdiscount = totalafterdiscount;
                    }
                }
            }
            else if (typeofjoinery == "200x300")
            {
                price = 250;
                if (joineries > 25 && joineries <= 50)
                {
                    total = joineries * price;
                    totalafterdiscount = total * 0.9;
                    if (shipmentmethod == "with delivery")
                    {
                        totalafterdiscount = totalafterdiscount + delivery;
                    }
                    else if (shipmentmethod == "without delivery")
                    {
                        totalafterdiscount = totalafterdiscount;
                    }
                }
                else if (joineries > 50 && joineries <= 99)
                {
                    total = joineries * price;
                    totalafterdiscount = total * 0.14;
                    if (shipmentmethod == "with delivery")
                    {
                        totalafterdiscount = totalafterdiscount + delivery;
                    }
                    else if (shipmentmethod == "without delivery")
                    {
                        totalafterdiscount = totalafterdiscount;
                    }
                }
                else if (joineries >= 10 && joineries <= 25)
                {
                    total = joineries * price;
                    totalafterdiscount = total;
                    if (shipmentmethod == "with delivery")
                    {
                        totalafterdiscount = totalafterdiscount + delivery;
                    }
                    else if (shipmentmethod == "without delivery")
                    {
                        totalafterdiscount = totalafterdiscount;
                    }
                }
                else if (joineries < 10)
                {
                    Console.WriteLine("Invalid order.");
                }
                else if (joineries > 99)
                {
                    total = joineries * price;
                    totalafterdiscount = total * 0.8;
                    if (shipmentmethod == "with delivery")
                    {
                        totalafterdiscount = totalafterdiscount + delivery;
                        totalafterdiscount = totalafterdiscount * discount99;
                    }
                    else if (shipmentmethod == "without delivery")
                    {
                        totalafterdiscount = totalafterdiscount;
                    }
                }
            }
            Console.WriteLine($"{totalafterdiscount:F2} BGN");
        }
    }
}
