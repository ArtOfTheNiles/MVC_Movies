namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingCustomerDbo : DbMigration
    {
        public override void Up()
        {
            //Populating Membership Charts
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 300, 12, 20)");

            //Populating Movie Info
            Sql("INSERT INTO Movies (Name) VALUES ('Shrek 2 The Shrekkening')");
            Sql("INSERT INTO Movies (Name) VALUES ('Shrek 3 Son of Shrek')");
            Sql("INSERT INTO Movies (Name) VALUES ('Shrek 4 Get Shrekked')");
            Sql("INSERT INTO Movies (Name) VALUES ('Star Shrek Deep Space Why')");
            Sql("INSERT INTO Movies (Name) VALUES ('Godzilla vs Shrek')");
            Sql("INSERT INTO Movies (Name) VALUES ('Fullmetal Jacket')");

            //Populating Customer Info
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Username, Password) VALUES ('Carson Daly', 1, 4, 'cdog101', 'carDog77')");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Username, Password) VALUES ('Atilla the Hun', 1, 2, 'IOWNCHINA99', 'puppiesnkitties1')");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Username, Password) VALUES ('Samuel L Jackson', 0, 1, 'SamDammit', 'whydisignupforthisanyway')");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Username, Password) VALUES ('Steve Harrington', 1, 2, 'TheHair84', 'allaboutthewoosh')");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Username, Password) VALUES ('Mark Twain', 1, 4, 'TheMTwain', 'riversnboatsnstuff')");


        }
        
        public override void Down()
        {
        }
    }
}
