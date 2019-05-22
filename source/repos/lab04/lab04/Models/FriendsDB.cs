using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace lab04.Models
{
    public class FriendsDB : DbContext
    {
        public DbSet<FriendModel> Friends { get; set; }
    }
}