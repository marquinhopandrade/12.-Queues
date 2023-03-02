using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._Queues
{
    internal class Order
    {
        //order ID
        public int OrderId { get; set; }

        //quantity of the order
        public int OrderQuantity { get; set; }

        //simple constructor
        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }
        //print message on the screen that the order was processed
        public void ProcessOrder()
        {
            //print the message
            Console.WriteLine($"Order {OrderId} processed!.");
        }
    }
}
