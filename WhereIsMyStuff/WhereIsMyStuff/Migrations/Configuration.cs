namespace WhereIsMyStuff.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WhereIsMyStuff.DAL.StuffDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WhereIsMyStuff.DAL.StuffDB context)
        {
   
            context.Entries.AddOrUpdate(p => p.Entry_Id,
                new Entry()
                {
                    Entry_Id = 1,
                    DateBorrowed = new DateTime(2017, 9, 14),
                    Item = "The Foundation Trilogy",
                    ItemType = "Book",
                    ItemCondition = "New",
                    Notes = "Collector's edition",
                    ItemBorrower = borrower1
                },

                 new Entry()
                 {
                     Entry_Id = 2,
                     DateBorrowed = new DateTime(2017, 9, 23),
                     Item = "Dune",
                     ItemType = "Book",
                     ItemCondition = "New",
                     Notes = "Collector's edition",
                     ItemBorrower = borrower1
                 },

                  new Entry()
                  {
                      Entry_Id = 3,
                      DateBorrowed = new DateTime(2017, 9, 24),
                      Item = "TARDIS Hoodie",
                      ItemType = "Clothing",
                      ItemCondition = "Normal wear and tear",
                      Notes = "",
                      ItemBorrower = borrower2
                  },

                   new Entry()
                   {
                       Entry_Id = 4,
                       DateBorrowed = new DateTime(2017, 8, 29),
                       Item = "Breat of the Wild",
                       ItemType = "Video game",
                       ItemCondition = "New",
                       Notes = "Switch game",
                       ItemBorrower = borrower5
                   },

                    new Entry()
                    {
                        Entry_Id = 5,
                        DateBorrowed = new DateTime(2017, 8, 29),
                        Item = "Breath of the Wild",
                        ItemType = "Book",
                        ItemCondition = "New",
                        Notes = "Collector's edition",
                        ItemBorrower = borrower5
                    },

                     new Entry()
                     {
                         Entry_Id = 6,
                         DateBorrowed = new DateTime(2017, 10, 20),
                         Item = "Face Painting Kit",
                         ItemType = "Other",
                         ItemCondition = "Used",
                         Notes = "Will return after Halloween, missing blue paint",
                         ItemBorrower = borrower3
                     },

                      new Entry()
                      {
                          Entry_Id = 7,
                          DateBorrowed = new DateTime(2017, 10, 20),
                          Item = "Long Blue Wig",
                          ItemType = "Other",
                          ItemCondition = "Normal wear and tear",
                          Notes = "Will return after Halloween",
                          ItemBorrower = borrower3
                      },

                       new Entry()
                       {
                           Entry_Id = 8,
                           DateBorrowed = new DateTime(2017, 10, 20),
                           Item = "Red Tights",
                           ItemType = "Clothing",
                           ItemCondition = "Damaged",
                           Notes = "Hole in left foot",
                           ItemBorrower = borrower3
                       },

                        new Entry()
                        {
                            Entry_Id = 9,
                            DateBorrowed = new DateTime(2017, 3, 14),
                            Item = "Jumper Cables",
                            ItemType = "Tools",
                            ItemCondition = "Normal wear and tear",
                            Notes = "Collector's edition",
                            ItemBorrower = borrower4
                        }
            );


        }
    }
}


