using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using TaskSoftline.Models;

namespace TaskSoftline.Controllers
{
    public class HomeController : Controller
    {
        IRepository repo;
        public HomeController(IRepository r)
        {
            repo = r;
        }

        public ActionResult Index()
        {
            return View(repo.ListProducts());
        }

        public ActionResult ProjectView()
        {
            IEnumerable<NecessaryGood> listNecessaryGood = repo.ListNecessaryGood();
            IEnumerable<Product> listProducts = repo.ListProducts();
            IEnumerable<Price> listPrices = repo.ListPrices();
            IEnumerable<Provider> listProviders = repo.ListProviders();
            List<String> unprocessed = new List<String>();
            List<ResultCart> result = new List<ResultCart>();

            List<string> allNecessaryGood = (from lst in listNecessaryGood
                      select lst.Name).ToList();

            var res = from prices in listPrices
                         join product in listProducts on prices.ProductId equals product.Id
                         join provider in listProviders on prices.ProviderId equals provider.Id
                         join necessaryGood in listNecessaryGood on product.Name equals necessaryGood.Name
                         select new
                         {
                             Name = product.Name,
                             Cost = prices.Cost,
                             ProviderName = provider.ProviderName,
                             DeliveryDays = provider.DeliveryDays,
                             Amount = necessaryGood.Amount
                         };

            foreach(var r in res)
            {
                allNecessaryGood.Remove(r.Name);
                result.Add(new ResultCart
                {
                    Amount = r.Amount,
                    Name = r.Name,
                    ProviderName = r.ProviderName,
                    TotalCost = r.Amount * r.Cost,
                    DLData = DateTime.Now.AddDays(r.DeliveryDays)
                });
            }

            var unprocessedOrders = from lst in listNecessaryGood
                                    where allNecessaryGood.Contains(lst.Name)
                                    select lst;

            foreach (var l in unprocessedOrders)
            {
                result.Add(new ResultCart
                {
                    Amount = l.Amount,
                    Name =l.Name,
                    ProviderName = "Нет продавцов",
                    TotalCost = 0,
                });
            }

            return View(result);
        }

        public ActionResult PriceList()
        {
            return View(repo.ListPrices());
        }
    }

    class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
    }
    class Team
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}