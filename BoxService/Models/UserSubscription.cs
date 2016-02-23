using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BoxService.Models
{
    public class UserSubscription
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [Display(Name = "Subscription Cost")]
        [DisplayFormat(DataFormatString = "{0:C}",ApplyFormatInEditMode = true)]
        public decimal SubscriptionCost { get; set; }
        [Display(Name = "Total Monthly Subscription Cost")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public decimal TotalSubscriptionCost { get; set; }
    }

    public class SubscriptionDbContext : DbContext
    {
        public DbSet<UserSubscription> UserSubscriptions { get; set; }
    }
}