using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TaskSoftline.Util;

namespace TaskSoftline.Models
{

    public class TaskContext : DbContext
    {
        //static TaskContext()
        //{
        //    Database.SetInitializer<TaskContext>(new DbInit());
        //}


        public TaskContext() : base("DefaultConnection") { }

        public DbSet<Product> Products { get; set; }

        public DbSet<Price> Prices { get; set; }

        public DbSet<Provider> Providers { get; set; }

        public DbSet<NecessaryGood> NecessaryGoods { get; set; }  
    }
}