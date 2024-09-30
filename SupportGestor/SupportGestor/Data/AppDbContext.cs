﻿using Microsoft.EntityFrameworkCore;
using SupportGestor.Models;

namespace SupportGestor.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
        public DbSet<Atendimento> Atendimentos { get; set; }
    }

}