using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBCustomLinq.Context;
internal class TBDbContext : DbContext
{
    private readonly ILoggerFactory loggerFactory;

    public DbSet<UserModel> Users { get; set; }

    public TBDbContext()
    {

    }
    public TBDbContext(ILoggerFactory loggerFactory)
    {
        this.loggerFactory = loggerFactory;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLoggerFactory(loggerFactory);
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=YoutubeBlazorsozluk;Persist Security Info=True;User ID=sa;Password=Salih123!");
        optionsBuilder.EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserModel>().ToTable("tbusers");
    }
}
