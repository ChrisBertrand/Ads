using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AdvertisingApp.Models
{
    public class AdvertContext : DbContext
    {
        public AdvertContext (DbContextOptions<AdvertContext> options)
            : base(options)
        {
        }

        public DbSet<AdvertisingApp.Models.Advert> Advert { get; set; }
    }
}
