using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BoxService.Models
{
    public class RegisteredUser
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Gender { get; set; }
    }

    public class RegisteredUserDbContext : DbContext
    {
        public DbSet<RegisteredUser> RegisteredUsers { get; set; }
    }
}