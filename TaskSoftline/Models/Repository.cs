using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskSoftline.Models
{

    public interface IRepository
    {
        IEnumerable<Product> ListProducts();
        IEnumerable<Provider> ListProviders();
        IEnumerable<NecessaryGood> ListNecessaryGood();
        IEnumerable<Price> ListPrices();

    }

    public class BookRepository : IDisposable, IRepository
    {
        public TaskContext db = new TaskContext();

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<Product> ListProducts()
        {
            return db.Products;
        }

        public IEnumerable<Provider> ListProviders()
        {
            return db.Providers;
        }

        public IEnumerable<NecessaryGood> ListNecessaryGood()
        {
            return db.NecessaryGoods;
        }

        public IEnumerable<Price> ListPrices()
        {
            return db.Prices;
        }
    }
}