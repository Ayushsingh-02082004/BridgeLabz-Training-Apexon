using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.ConditionalStatements
{
    internal class MovieTicket
    {
        public void movieticket(int age , int price)
        {
            if (age < 12)
            {
                double discount = price * 0.30;   // 30% discount
                double finalPrice = price - discount;
                Console.WriteLine("30% discount applied. Final ticket price: " + finalPrice);
            }
            else if (age >= 12 && age <= 64)
            {
                Console.WriteLine("Ticket price: " + price);
            }
            else
            {
                double discount = price * 0.20;   // 20% discount
                double finalPrice = price - discount;
                Console.WriteLine("20% senior citizen discount applied. Final ticket price: " + finalPrice);
            }
        }
    }
}
