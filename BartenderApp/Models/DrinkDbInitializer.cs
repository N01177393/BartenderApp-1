using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BartenderApp.Models
{
    public class DrinkDbInitializer
    {
        public static void Initialize()
        {
            //Create instance of drinks
            DrinkDbContext Context = new DrinkDbContext();

            //If there are drinks already, do not recreate them
            if (Context.Drinks.Any())
            {
                return;
            }

            //Add drinks to the menu
            var drinks = new Drink[]
            {
                new Drink
                {
                    DrinkID = 1,
                    DrinkName = "Manhattan",
                    DrinkDescription = "Classic cocktail with a twist. Rye whiskey, vermouth, bitters, and garnished with a cherry. Bet you can't tie the stem with your tongue.",
                    DrinkPrice = 8
                },
                new Drink
                {
                    DrinkID = 2,
                    DrinkName = "Martini",
                    DrinkDescription = "Simple, but delicious. Gin, vermouth, and orange bitters. Don't fix it if it ain't broken.",
                    DrinkPrice = 8
                },
                new Drink
                {
                    DrinkID = 3,
                    DrinkName = "Old Fashioned",
                    DrinkDescription = "Old fashioned... That's right. Bourdon, simple syrup, orange bitters, and garnished with a cherry. Just the way you like it.",
                    DrinkPrice = 8
                },
                new Drink
                {
                    DrinkID = 4,
                    DrinkName = "Screwdriver",
                    DrinkDescription = "A classic. Vodka and orange Juice. Sweet and tangy, how could you go wrong?",
                    DrinkPrice = 6
                }
            };

            //Add drinks to the database 
            foreach (Drink d in drinks)
            {
                Context.Drinks.Add(d);
            }
   
            //Save added changes
            Context.SaveChanges();
        }
    }
}