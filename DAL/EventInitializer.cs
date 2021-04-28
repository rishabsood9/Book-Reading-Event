using System.Data.Entity;
using Shared;
using System.Collections.Generic;
using System;

namespace DAL
    {
    public class EventInitializer:DropCreateDatabaseIfModelChanges<BookReadingContext>
        {
           protected override void Seed(BookReadingContext bookReadingContext)
            {
            
            var users = new List<User>
            {
                new User{UserName="Ankit Jaitak" , EmailId="ankit.jaitak@nagarro.com" , Password="12345" },
                new User{UserName="Rishav Salodhia" , EmailId="rishav.salodhia@nagarro.com" , Password="12345"},
                new User{UserName="Kunal Garg" , EmailId="kunal.garg@nagarro.com" , Password="12345" },
                new User{UserName="Chirag Mahajan" , EmailId="chirag.mahajan@nagarro.com" , Password="12345" },
                new User{UserName="Hitesh Satija" , EmailId="Hitesh.Satija@nagarro.com" , Password="12345" },
                new User{UserName="Jaspreet Singh" , EmailId="jaspreet.singh@nagarro.com" , Password="12345" },
                new User{UserName="Yogesh Saili" , EmailId="yogesh.saili@nagarro.com" , Password="12345" },
                new User{ UserName="Manish Goyal" , EmailId="manish.goyal@nagarro.com" , Password="12345" },
                new User{UserName="Mitesh Kapasia" , EmailId="mitesh.kapasia@nagarro.com" , Password="12345" },
                new User{ UserName="Kavan Patel" , EmailId="kavan.patel@nagarro.com" , Password="12345" },
                new User{UserName="Shweta Gautam",EmailId="myAdmin@gmail.com",Password="12345"}
            };
            users.ForEach(s => bookReadingContext.Users.Add(s));
            bookReadingContext.SaveChanges();
            var events = new List<Event>
                {
               new Event{ Title="Three mistakes of my life",Date=DateTime.Now, Location="Plot 13", Duration=3, StartTime=DateTime.Now, Description=" A GOOD BOOK 1",OtherDetails=null,Type=EventType.PRIVATE,InviteByEmail=null,UserId="Kavan Patel"  }
               };
            events.ForEach(s => bookReadingContext.Events.Add(s));
            bookReadingContext.SaveChanges();
            var roles = new List<Role>
                {
                new Role{AssignedRole="Admin",UserId="Shweta Gautam"},
                new Role { AssignedRole = "User", UserId = "Shweta Gautam" },
                new Role{AssignedRole="User",UserId="Ankit Jaitak"},
                new Role{AssignedRole="User",UserId="Rishav Salodhia"},
                new Role{AssignedRole="User",UserId="Kunal Garg"},
                new Role{AssignedRole="User",UserId="Chirag Mahajan"},
                new Role{AssignedRole="User",UserId="Hitesh Satija"},
                new Role{AssignedRole="User",UserId="Jaspreet Singh"},
                new Role{AssignedRole="User",UserId="Yogesh Saili"},
                new Role{AssignedRole="User",UserId="Manish Goyal"},
                new Role{AssignedRole="User",UserId="Mitesh Kapasia"},
                new Role{AssignedRole="User",UserId="Kavan Patel"},
          
            };
            roles.ForEach(s => bookReadingContext.Roles.Add(s));
            bookReadingContext.SaveChanges();
            }
        }
    }
