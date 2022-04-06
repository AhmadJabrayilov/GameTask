using System;
using System.Collections.Generic;
using System.Text;
using Utils.Enums;

namespace Entities
{
    class Game
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public Platform  Platform { get; set; }

        public double Price { get; set; }

        public double DiscountPercent { get; set; }
        public string Publisher { get; set; }
        public bool IsDelete { get; set; }

     


        public void ShowInfo()
        {
            Console.WriteLine($"ID: {Id}\nName: {Name}\nPlatform: {Platform}\nPrice: {Price}\n DiscountPercent {DiscountPercent}\nPublisher: {Publisher} \nIsDelete: {IsDelete}");
        }

        public double GetDiscountedPrice()
        {
           return Price - (Price * DiscountPercent)/ 100;
        }


    }
}
