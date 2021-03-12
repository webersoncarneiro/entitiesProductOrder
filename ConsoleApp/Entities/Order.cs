using System;
using System.Text;
using System.Collections.Generic;
using ConsoleApp.Entities;
using ConsoleApp.Entities.Enums;
using System.Globalization;

namespace ConsoleApp.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();


        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;

        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void Remove(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Moment: " + Moment.ToString("dd/MM/yyyy HH:MM:ss"));
            sb.AppendLine("Order Status" + Status);
            sb.AppendLine("Client :" + Client);
            sb.AppendLine("Order item :");
            foreach(OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Total price: $ " + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

        } 
       
    }



