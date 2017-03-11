using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace CoffeeSnobs.Models
{
    public class CoffeeSnobsDbInitializer : DropCreateDatabaseIfModelChanges<CoffeeSnobsDB>
    {
        protected override void Seed(CoffeeSnobsDB context)
        {
            context.Reviews.AddOrUpdate(new Review {
                                                        ReviewId = 1,
                                                        Date = "02/17/16",
                                                        Email = "sally@aol.com",
                                                        Shop = "Nordic Coffee",
                                                        City = "Poulsbo",
                                                        Drink = "Mocha",
                                                        CoffeeRating = 1,
                                                        ServRating = 1,
                                                        Return = "No" });
            context.Reviews.AddOrUpdate(new Review {
                                                        ReviewId = 2,
                                                        Date = "07/27/16",
                                                        Email = "joe@aol.com",
                                                        Shop = "Latte On Your Way",
                                                        City = "Poulsbo",
                                                        Drink = "Caramel Latte",
                                                        CoffeeRating = 2,
                                                        ServRating = 2,
                                                        Return = "No" });
            context.Reviews.AddOrUpdate(new Review {
                                                        ReviewId = 3,
                                                        Date = "12/05/16",
                                                        Email = "tom@aol.com",
                                                        Shop = "Tullys",
                                                        City = "Bremerton",
                                                        Drink = "Drip Coffee (Dark Roast)",
                                                        CoffeeRating = 3,
                                                        ServRating = 3,
                                                        Return = "Maybe" });
            context.Reviews.AddOrUpdate(new Review {
                                                        ReviewId = 4,
                                                        Date = "01/10/17",
                                                        Email = "kim@aol.com",
                                                        Shop = "Hot Shots Java",
                                                        City = "Poulsbo",
                                                        Drink = "Americano",
                                                        CoffeeRating = 4,
                                                        ServRating = 4,
                                                        Return = "Yes" });
            context.Reviews.AddOrUpdate(new Review {
                                                        ReviewId = 5,
                                                        Date = "02/24/17",
                                                        Email = "will@aol.com" ,
                                                        Shop = "Starbucks",
                                                        City = "Silverdale",
                                                        Drink = "Coconut Macchiato",
                                                        CoffeeRating = 5,
                                                        ServRating = 5,
                                                        Return = "Yes" });

            base.Seed(context);
        }
    }
}