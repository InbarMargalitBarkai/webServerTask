using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webServerTask.Models;

namespace webServerTask.Data
{
    public class webServerTaskContext : DbContext
    {
        public webServerTaskContext (DbContextOptions<webServerTaskContext> options)
            : base(options)
        {
        }

        public DbSet<webServerTask.Models.User>? User { get; set; }

        public DbSet<webServerTask.Models.Message>? Message { get; set; }

        public DbSet<webServerTask.Models.Conversation>? Conversation { get; set; }
        public DbSet<webServerTask.Models.Contact>? Contact { get; set; }

    }
}
