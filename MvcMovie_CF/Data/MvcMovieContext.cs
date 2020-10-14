﻿using Microsoft.EntityFrameworkCore;
using MvcMovie_CF.Models;

namespace MvcMovie_CF.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
    }
}
