using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TaskSoftline.Models;

namespace TaskSoftline.Util
{
    public class DbInit : DropCreateDatabaseAlways<TaskContext>
    {
        protected override void Seed(TaskContext context)
        {
            for (int i = 1; i <= 10; i++)
            {
                context.Products.Add(new Product{
                    Name = "Материал №" + i.ToString(),
                });
            }

            context.Providers.Add(new Provider
            {
                ProviderName = "Поставшик №1",
                DeliveryDays = 14
            });

            context.Providers.Add(new Provider
            {
                ProviderName = "Поставшик №2",
                DeliveryDays = 7
            });

            context.Providers.Add(new Provider
            {
                ProviderName = "Поставшик №3",
                DeliveryDays = 30
            });

            context.Prices.Add(new Price { Cost = 500 });
            context.Prices.Add(new Price { Cost = 600 });
            context.Prices.Add(new Price { Cost = 1000 });
            context.Prices.Add(new Price { Cost = 1101 });
            context.Prices.Add(new Price { Cost = 200 });
            context.Prices.Add(new Price { Cost = 100 });
            context.Prices.Add(new Price { Cost = 40 });

            context.NecessaryGoods.Add(new NecessaryGood
            {
                Name = "Материал №1",
                Amount = 100
            });

            context.NecessaryGoods.Add(new NecessaryGood
            {
                Name = "Материал №2",
                Amount = 20
            });
            context.NecessaryGoods.Add(new NecessaryGood
            {
                Name = "Материал №3",
                Amount = 30
            });
            context.NecessaryGoods.Add(new NecessaryGood
            {
                Name = "Материал №4",
                Amount = 44
            });
            context.NecessaryGoods.Add(new NecessaryGood
            {
                Name = "Материал №5",
                Amount = 555
            });
            context.NecessaryGoods.Add(new NecessaryGood
            {
                Name = "Материал №6",
                Amount = 60
            });
            context.NecessaryGoods.Add(new NecessaryGood
            {
                Name = "Материал №7",
                Amount = 777
            });
            context.NecessaryGoods.Add(new NecessaryGood
            {
                Name = "Материал №8",
                Amount = 20
            });
            context.NecessaryGoods.Add(new NecessaryGood
            {
                Name = "Материал №9",
                Amount = 30
            });
            context.NecessaryGoods.Add(new NecessaryGood
            {
                Name = "Материал №10",
                Amount = 10
            });

            base.Seed(context);
        }
    }
}