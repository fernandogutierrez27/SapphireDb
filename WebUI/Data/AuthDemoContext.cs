﻿using Microsoft.EntityFrameworkCore;
using SapphireDb;
using WebUI.Data.AuthDemo;

namespace WebUI.Data
{
    public class AuthDemoContext : RealtimeContext
    {
        public AuthDemoContext(DbContextOptions<RealtimeContext> options, SapphireDatabaseNotifier notifier) : base(options, notifier)
        {
        }

        public DbSet<RequiresAuthForQuery> RequiresAuthForQueryDemos { get; set; }
        
        public DbSet<RequiresAdminForQuery> RequiresAdminForQueryDemos { get; set; }
        
        public DbSet<CustomFunctionForQuery> CustomFunctionForQueryDemos { get; set; }
        
        public DbSet<CustomFunctionPerEntryForQuery> CustomFunctionPerEntryForQueryDemos { get; set; }
        
        public DbSet<QueryFields> QueryFieldDemos { get; set; }
    }
}