using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _002_EF;

public partial class EfContext : DbContext
{
    public EfContext()
    {
    }

    public EfContext(DbContextOptions<EfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("server=.;database=EF;Trusted_Connection=True;TrustServerCertificate = true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Fname).HasColumnName("FName");
            entity.Property(e => e.Lname).HasColumnName("LName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
