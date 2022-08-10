using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebApp2020.Shared.Models
{
    public partial class WebApp2020DbContext : IdentityDbContext<IdentityUser>
    {
        public WebApp2020DbContext()
        {
        }

        public WebApp2020DbContext(DbContextOptions<WebApp2020DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<BagType> BagType { get; set; }
        public virtual DbSet<Colour> Colour { get; set; }
        public virtual DbSet<CustomerAddresses> CustomerAddresses { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<PaymentType> PaymentType { get; set; }
        public virtual DbSet<ProductDetails> ProductDetails { get; set; }
        public virtual DbSet<ProductOrderDetails> ProductOrderDetails { get; set; }
        public virtual DbSet<RangeType> RangeType { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectsV13;Database=WebApp2020;Trusted_Connection=True;MultipleActiveResultSets=true");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // https://stackoverflow.com/questions/39798317/identityuserloginstring-requires-a-primary-key-to-be-defined-error-while-addi
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.HasKey(e => e.AddressId)
                    .HasName("PK_AddressID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Line1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Line2).HasMaxLength(100);

                entity.Property(e => e.Postcode)
                    .IsRequired()
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<BagType>(entity =>
            {
                entity.Property(e => e.BagTypeId).HasColumnName("BagTypeID");

                entity.Property(e => e.BagType1)
                    .IsRequired()
                    .HasColumnName("BagType")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Colour>(entity =>
            {
                entity.Property(e => e.ColourId).HasColumnName("ColourID");

                entity.Property(e => e.ColourName)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<CustomerAddresses>(entity =>
            {
                entity.HasKey(e => new { e.AddressId, e.CustomerId });

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AddressID");
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK_OrderID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .HasConstraintName("FK_PaymentTypeID");
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ExpirationDate)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.NameOnCard)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentMethod)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProductDetails>(entity =>
            {
                entity.HasKey(e => e.ProductCode)
                    .HasName("PK_ProductCode");

                entity.Property(e => e.BagTypeId).HasColumnName("BagTypeID");

                entity.Property(e => e.ColourId).HasColumnName("ColourID");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProductImage).HasMaxLength(50);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RangeId).HasColumnName("RangeID");

                entity.HasOne(d => d.BagType)
                    .WithMany(p => p.ProductDetails)
                    .HasForeignKey(d => d.BagTypeId)
                    .HasConstraintName("FK_BagTypeID");

                entity.HasOne(d => d.Colour)
                    .WithMany(p => p.ProductDetails)
                    .HasForeignKey(d => d.ColourId)
                    .HasConstraintName("FK_ColourID");

                entity.HasOne(d => d.Range)
                    .WithMany(p => p.ProductDetails)
                    .HasForeignKey(d => d.RangeId)
                    .HasConstraintName("FK_RangeID");
            });

            modelBuilder.Entity<ProductOrderDetails>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId });

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("decimal(29, 0)")
                    .HasComputedColumnSql("([Quantity]*[UnitPrice])");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.ProductOrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductOrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductID");
            });

            modelBuilder.Entity<RangeType>(entity =>
            {
                entity.HasKey(e => e.RangeId)
                    .HasName("PK_RangeID");

                entity.Property(e => e.RangeId).HasColumnName("RangeID");

                entity.Property(e => e.RangeName)
                    .IsRequired()
                    .HasMaxLength(25);
            });
        }
    }
}
