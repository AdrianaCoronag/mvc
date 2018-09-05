namespace Mvc.Migrations
{
    using Mvc.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Mvc.Models.CricketerDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Mvc.Models.CricketerDBContext context)
        {
            context.Cricketers.AddOrUpdate(i => i.Name,
 new Cricketer
 {
     Name = "Sachin Tendulkar",
     ODI = 463,
     Test = 198
 },
 new Cricketer
 {
     Name = "Saurav Ganguly",
     ODI = 311,
     Test = 113
 },
 new Cricketer
 {
     Name = "Rahul Dravid",
     ODI = 344,
     Test = 164
 },
 new Cricketer
 {
     Name = "Ricky Ponting",
     ODI = 375,
     Test = 168
 },
 new Cricketer
 {
     Name = "Wasim Akram",
     ODI = 356,
     Test = 104
 },
 new Cricketer
 {
     Name = "Jacques Kallis",
     ODI = 321,
     Test = 162
 },
 new Cricketer
 {
     Name = "Sanath Jayasuriya",
     ODI = 445,
     Test = 110
 }
 );
        }


        //  This method will be called after migrating to the latest version.

        //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
        //  to avoid creating duplicate seed data.
    }
}

