using System;
using System.Globalization;
using Course.Entities.Enums;
using System.Text;
using System.Collections.Generic;


namespace Course.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Client Client { get; set; }  
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus orderSatatus, Client client)
        {
            Moment = moment;
            OrderStatus = orderSatatus;
            Client = client;
        }

        public void AddOrderItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveOderItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double TotalOrder()
        {
            double total = 0;
            foreach(OrderItem item in Items)
            {
               total += item.ParcialPrice;
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Summary:");
            sb.Append("Order Moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order Status: ");
            sb.AppendLine(OrderStatus.ToString());
            sb.Append("Client: ");
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order Items:");

            foreach(OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine();
            sb.Append("Total: " + TotalOrder().ToString("F2", CultureInfo.InvariantCulture));
            
            return sb.ToString();

        }
    }
}
