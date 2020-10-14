using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie_CF.Models;

namespace MvcMovie_CF.Data
{
    public class MvcMovie_CFContext : DbContext
    {
        public MvcMovie_CFContext (DbContextOptions<MvcMovie_CFContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie_CF.Models.Movie> Movie { get; set; }
    }
}
