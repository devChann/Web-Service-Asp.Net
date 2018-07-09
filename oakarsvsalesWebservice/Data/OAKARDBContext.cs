using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using oakarsvsalesWebservice.Models;

namespace oakarsvsalesWebservice.Data
{
    public partial class OAKARDBContext : DbContext
    {
        public OAKARDBContext()
        {
        }

        public OAKARDBContext(DbContextOptions<OAKARDBContext> options)
            : base(options)
        {
        }

       
        public virtual DbSet<So011t> So011t { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<So011t>(entity =>
            {
                entity.HasKey(e => e.Ordid);

                entity.ToTable("__SO011T");

                entity.Property(e => e.Ordid)
                    .HasColumnName("ORDID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcMgr).HasMaxLength(100);

                entity.Property(e => e.Client).HasMaxLength(163);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.Createdby).HasMaxLength(50);

                entity.Property(e => e.Createddate).HasColumnType("datetime");

                entity.Property(e => e.Currency).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Dnote).HasMaxLength(20);

                entity.Property(e => e.Id1).HasColumnName("ID1");

                entity.Property(e => e.Invoice).HasMaxLength(50);

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.Invoiced)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Modby).HasMaxLength(20);

                entity.Property(e => e.Moddate).HasColumnType("datetime");

                entity.Property(e => e.OrderItem).HasMaxLength(500);

                entity.Property(e => e.OrderType).HasMaxLength(100);

                entity.Property(e => e.Orderby).HasMaxLength(100);

                entity.Property(e => e.Orderdate).HasColumnType("date");

                entity.Property(e => e.Orgn).HasMaxLength(80);

                entity.Property(e => e.Ponum)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ProductGroup).HasMaxLength(100);

                entity.Property(e => e.ProductId).HasMaxLength(10);

                entity.Property(e => e.ProductName).HasMaxLength(200);

                entity.Property(e => e.QuoteNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Quotedate).HasColumnType("datetime");

                entity.Property(e => e.SoldBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Supplierproductid).HasMaxLength(50);

                entity.Property(e => e.Tax).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Version).HasMaxLength(255);

                entity.Property(e => e.Wkt).HasColumnName("wkt");

                entity.Property(e => e.Xrate).HasColumnType("numeric(18, 2)");
            });
        }
    }
}
