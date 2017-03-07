using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace CoffeeSnobs.Models
{
    public class CoffeeSnobsDbInitializer : DropCreateDatabaseAlways<CoffeeSnobsDB>
    {
        protected override void Seed(CoffeeSnobsDB context)
        {
            context.Reviews.AddOrUpdate(new Review {
                                                        ReviewId = 1,
                                                        Date = "02/17/16",
                                                        Email = "sally@aol.com",
                                                        Shop = "Nordic Coffee",
                                                        Drink = "Mocha",
                                                        CoffeeRating = "*",
                                                        ServRating = "*",
                                                        Return = "No" });
            context.Reviews.AddOrUpdate(new Review {
                                                        ReviewId = 2,
                                                        Date = "07/27/16",
                                                        Email = "joe@aol.com",
                                                        Shop = "Latte On Your Way",
                                                        Drink = "Caramel Latte",
                                                        CoffeeRating = "**",
                                                        ServRating = "**",
                                                        Return = "No" });
            context.Reviews.AddOrUpdate(new Review {
                                                        ReviewId = 3,
                                                        Date = "12/05/16",
                                                        Email = "tom@aol.com",
                                                        Shop = "Tullys",
                                                        Drink = "Drip Coffee (Dark Roast)",
                                                        CoffeeRating = "***",
                                                        ServRating = "***",
                                                        Return = "Maybe" });
            context.Reviews.AddOrUpdate(new Review {
                                                        ReviewId = 4,
                                                        Date = "01/10/17",
                                                        Email = "kim@aol.com",
                                                        Shop = "Hot Shots Java",
                                                        Drink = "Americano",
                                                        CoffeeRating = "****",
                                                        ServRating = "****",
                                                        Return = "Yes" });
            context.Reviews.AddOrUpdate(new Review {
                                                        ReviewId = 5,
                                                        Date = "02/24/17",
                                                        Email = "will@aol.com" ,
                                                        Shop = "Starbucks",
                                                        Drink = "Coconut Macchiato",
                                                        CoffeeRating = "******",
                                                        ServRating = "*****",
                                                        Return = "Yes" });

            base.Seed(context);
        }
    }
}