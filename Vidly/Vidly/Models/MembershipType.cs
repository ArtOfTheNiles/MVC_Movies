using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        [Required]
        public byte Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        /*
         * 
         * Migration notes; because VS for Mac does not have access to Powershell to update databases:
                

        MIGRATION ONE ****************
        Add Name to Membership Type: Migration (this should be an automatic migration based on model updates)
           
        Up()
        AddColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
               

        Down()
        DropColumn("dbo.MembershipTypes", "Name");


        MIGRATION TWO ****************
        Seeding the Membership names
           
        SQL Update syntax:
        UPDATE [tablename] SET [dbo property = value] WHERE [conditional statement]

        Sql("UPDATE MembershipTypes SET Name = 'Pay as You Go' WHERE Id = 1");
        Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE Id = 2");
        Sql("UPDATE MembershipTypes SET Name = 'Quarterly' WHERE Id = 3");
        Sql("UPDATE MembershipTypes SET Name = 'Annual' WHERE Id = 4");


        MIGRATION THREE ****************          
        Seeding the Genre Types

        Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
        Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Thriller')");
        Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Family')");
        Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romance')");
        Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Comedy')");

           
        MIGRATION FOUR ****************           
        Seeding the genre for each movie entry.  This will take a little planning. 

        */



        public short SignUpFee { get; set; }

        public byte DurationInMonths { get; set; }

        public byte DiscountRate { get; set; }
    }
}