using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OpsPipelineAPI.Repository.EDMX;

#nullable disable

namespace OpsPipelineAPI.Repository.Models
{
    public partial class ReportContext : DbContext
    {
        public ReportContext()
        {
        }

        public ReportContext(DbContextOptions<ReportContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<MasterCity> MasterCities { get; set; }
        public virtual DbSet<MasterCountry> MasterCountries { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<testView> testView { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=shavez;Database=Report;User ID=sa;Password=sa123;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustCode)
                    .HasName("PK__CUSTOMER__8393C4A15D0FD85A");

                entity.ToTable("CUSTOMER");

                entity.Property(e => e.CustCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CUST_CODE");

                entity.Property(e => e.AgentCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("AGENT_CODE")
                    .IsFixedLength(true);

                entity.Property(e => e.CustCity)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("CUST_CITY")
                    .IsFixedLength(true);

                entity.Property(e => e.CustCountry)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUST_COUNTRY");

                entity.Property(e => e.CustName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUST_NAME");

                entity.Property(e => e.Grade).HasColumnName("GRADE");

                entity.Property(e => e.OpeningAmt).HasColumnName("OPENING_AMT");

                entity.Property(e => e.OutstandingAmt).HasColumnName("OUTSTANDING_AMT");

                entity.Property(e => e.PaymentAmt).HasColumnName("PAYMENT_AMT");

                entity.Property(e => e.PhoneNo)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("PHONE_NO");

                entity.Property(e => e.ReceiveAmt).HasColumnName("RECEIVE_AMT");

                entity.Property(e => e.WorkingArea)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("WORKING_AREA");
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.ToTable("ErrorLog");

                entity.Property(e => e.Col).HasColumnName("col");

                entity.Property(e => e.Line).HasColumnName("line");

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<MasterCity>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("Master_City");
            });

            modelBuilder.Entity<MasterCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("Master_Country");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.ToTable("settings");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<testView>(entity =>
            {
                entity.HasNoKey();
                entity.ToView("testView");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
