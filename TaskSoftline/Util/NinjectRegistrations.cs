﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using TaskSoftline.Models;

namespace TaskSoftline.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository>().To<BookRepository>();
        }
    }
}