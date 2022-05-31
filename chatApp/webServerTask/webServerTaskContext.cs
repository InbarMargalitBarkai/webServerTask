using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webServerTask.Models;

namespace webServerTask
{
    public class webServerTaskContext : DbContext
    {
        public webServerTaskContext() { }

        //public webServerTaskContext(DbContextOptions<webServerTaskContext> options)
        //    : base(options)
        //{
        //}


        public webServerTaskContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User>? User { get; set; }

        public DbSet<Message>? Message { get; set; }

        public DbSet<Conversation>? Conversation { get; set; }
        public DbSet<Contact>? Contact { get; set; }

    }
}
