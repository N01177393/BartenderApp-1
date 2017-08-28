using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BartenderApp.Models
{
    public class DrinkDbContext : DbContext
    {
        //Create menus 
        public DbSet<Drink> Drinks { get; set; }
    }
}