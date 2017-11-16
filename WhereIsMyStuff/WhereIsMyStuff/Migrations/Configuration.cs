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
                    FirstName = "Brandon",
                    LastName = "Sanderson"
                },

                 new Entry()
                 {
                     Entry_Id = 2,
                     DateBorrowed = new DateTime(2017, 9, 23),
                     Item = "Dune",
                     ItemType = "Book",
                     ItemCondition = "New",
                     Notes = "Collector's edition",
                     FirstName = "Brandon",
                     LastName = "Sanderson"
                 },

                  new Entry()
                  {
                      Entry_Id = 3,
                      DateBorrowed = new DateTime(2017, 9, 24),
                      Item = "TARDIS Hoodie",
                      ItemType = "Clothing",
                      ItemCondition = "Normal wear and tear",
                      Notes = "Left sleeve is frayed",
                      FirstName = "Betty",
                      LastName = "Fuego"
                  },

                   new Entry()
                   {
                       Entry_Id = 4,
                       DateBorrowed = new DateTime(2017, 8, 29),
                       Item = "Breath of the Wild",
                       ItemType = "Video game",
                       ItemCondition = "New",
                       Notes = "Switch game",
                       FirstName = "Terry",
                       LastName = "Pratchett"
                   },

                    new Entry()
                    {
                        Entry_Id = 5,
                        DateBorrowed = new DateTime(2017, 8, 29),
                        Item = "Breath of the Wild",
                        ItemType = "Book",
                        ItemCondition = "New",
                        Notes = "Collector's edition",
                        FirstName = "Terry",
                        LastName = "Pratchett"
                    },

                     new Entry()
                     {
                         Entry_Id = 6,
                         DateBorrowed = new DateTime(2017, 10, 20),
                         Item = "Face Painting Kit",
                         ItemType = "Other",
                         ItemCondition = "Used",
                         Notes = "Will return after Halloween, missing blue paint",
                         FirstName = "Neil",
                         LastName = "Gaiman"
                     },

                      new Entry()
                      {
                          Entry_Id = 7,
                          DateBorrowed = new DateTime(2017, 10, 20),
                          Item = "Long Blue Wig",
                          ItemType = "Other",
                          ItemCondition = "Normal wear and tear",
                          Notes = "Will return after Halloween",
                          FirstName = "Neil",
                          LastName = "Gaiman"
                      },

                       new Entry()
                       {
                           Entry_Id = 8,
                           DateBorrowed = new DateTime(2017, 10, 20),
                           Item = "Red Tights",
                           ItemType = "Clothing",
                           ItemCondition = "Damaged",
                           Notes = "Hole in left foot",
                           FirstName = "Neil",
                           LastName = "Gaiman"
                       },

                        new Entry()
                        {
                            Entry_Id = 9,
                            DateBorrowed = new DateTime(2017, 3, 14),
                            Item = "Jumper Cables",
                            ItemType = "Tools",
                            ItemCondition = "Normal wear and tear",
                            Notes = "Collector's edition",
                            FirstName = "Isaac",
                            LastName = "Asimov"
                        }
            );


        }
    }
}


