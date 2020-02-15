using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HappyPub.Models;
using DateTime = HappyPub.Models.DateTime;

namespace HappyPub.DAL
{
    public class PubInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PubContext>
    {
        protected override void Seed(PubContext context)
        {
            var items = new List<Item>
            {
                new Item{ItemId=1, Name="Beer", Description="Beer", Price=2m, Category="DRINK", Visible=true},
                new Item{ItemId=2, Name="Red Wine", Description="Red Wine", Price=4m, Category="DRINK", Visible=true},
                new Item{ItemId=3, Name="White Wine", Description="White Wine", Price=4m, Category="DRINK", Visible=true}
             };

            items.ForEach(s => context.Items.Add(s));
            context.SaveChanges();
            var orders = new List<Order>
            {
                new Order{OrderId=1, UserId=1111, Total=6m, CreateDate=DateTime.Parse("2020-06-09")},
                new Order{OrderId=2, UserId=2222, Total=4m, CreateDate=DateTime.Parse("2020-06-09")}
            };
            orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();
            var orderItems = new List<OrderItem>
            {
                new OrderItem{OrderItemId=1, OrderId=1, ItemId=1, Quantity=1, Price=2m},
                new OrderItem{OrderItemId=2, OrderId=1, ItemId=2, Quantity=1, Price=4m},
                new OrderItem{OrderItemId=3, OrderId=2, ItemId=3, Quantity=1, Price=4m}
            };
            orderItems.ForEach(s => context.OrderItems.Add(s));
            context.SaveChanges();
        }
    }
}