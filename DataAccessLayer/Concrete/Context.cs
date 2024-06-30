using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
	public class Context : DbContext
	{
		public Context(DbContextOptions dbContextOptions) : base(dbContextOptions)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// ProductCode'u unique yap
			modelBuilder.Entity<Product>()
				.HasIndex(p => p.ProductCode)
				.IsUnique();

			// StockCode'u unique yap
			modelBuilder.Entity<Stock>()
				.HasIndex(s => s.StockCode)
				.IsUnique();


			modelBuilder.Entity<Stock>()
				.HasOne(s => s.Product)
				.WithMany(p => p.Stocks)
				.HasForeignKey(s => s.ProductCode)
				.HasPrincipalKey(p => p.ProductCode);


			modelBuilder.Entity<Stock>()
				.HasOne(s => s.Admin)
				.WithMany(a => a.Stocks)
				.HasForeignKey(s => s.AdminID);
		}

		public DbSet<Admin> Admins{ get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stocks  { get; set; }
		public DbSet<User> Users { get; set; }
    }
}
