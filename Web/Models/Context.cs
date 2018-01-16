﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Web.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
               : base(options)
        {
        }

        

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<WishlistItem> WishlistItem { get; set; }
        public DbSet<LoginDto> LoginDto { get; set; }
        public DbSet<Token> Token { get; set; }

    }
}
