﻿using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure
{
    public class EssentiBotContext : DbContext
    {
        public DbSet<Server> Servers { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<AutoRole> AutoRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("server=localhost;Database=EssentiBot;Trusted_Connection=True;MultipleActiveResultSets=true");       
    }

    public class Server
    {
        public ulong Id { get; set; }
        public string Prefix { get; set; }
        public ulong Welcome { get; set; }
        public string Background { get; set; }
        public ulong Logs { get; set; }
    }

    public class Rank
    {
        public int Id { get; set; }
        public ulong RoleId { get; set; }
        public ulong ServerId { get; set; }
    }

    public class AutoRole
    {
        public int Id { get; set; }
        public ulong RoleId { get; set; }
        public ulong ServerId { get; set; }
    }
}
