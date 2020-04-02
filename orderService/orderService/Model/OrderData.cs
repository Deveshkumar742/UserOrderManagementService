using System;
using System.Collections.Generic;

namespace orderService.Model
{
    public sealed class OrderData
    {
        private static OrderData instance = null;

        public List<Order> orders = new List<Order>();

        private OrderData()
        {
            orders = new List<Order>()
            {
                new Order() { orderId = 1, orderAmount=2500, orderDate=System.DateTime.Now },
                new Order() { orderId = 2, orderAmount=3000, orderDate=System.DateTime.Now}
            };
        }

        public static OrderData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderData();
                }
                return instance;
            }
        }
    }

    public class Order
    {
        public int orderId { get; set; }

        public int orderAmount { get; set; }

        public DateTime orderDate { get; set; }
    }
}
