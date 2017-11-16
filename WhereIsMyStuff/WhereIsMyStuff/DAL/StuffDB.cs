﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WhereIsMyStuff.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WhereIsMyStuff.DAL
{
    public class StuffDB :DbContext
    {
        public StuffDB() : base("StuffDB")
        {

        }
        public DbSet<Entry> Entries { get; set; }

    }
}