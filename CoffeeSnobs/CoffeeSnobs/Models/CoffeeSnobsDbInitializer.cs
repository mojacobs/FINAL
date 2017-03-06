using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CoffeeSnobs.Models
{
    public class CoffeeSnobsDbInitializer : DropCreateDatabaseIfModelChanges
    {
        protected override void Seed(CoffeeSnobsDB context)
        {
            context.Reviews.AddOrUpdate(new Campus { CampusId = 1, Name = "Bremerton", Address = "1600 Chester Ave.", City = "Bremerton" });
            context.Campus.AddOrUpdate(new Campus { CampusId = 2, Name = "Poulsbo", Address = "1000 Olympic College Place NW", City = "Poulsbo" });
            context.Campus.AddOrUpdate(new Campus { CampusId = 3, Name = "PSNS", Address = "Naval Base Kitsap", City = "Bremerton" });
          
            base.Seed(context);
        }
    }
}