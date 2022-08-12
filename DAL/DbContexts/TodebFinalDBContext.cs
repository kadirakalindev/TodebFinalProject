using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Models.Entities;

#nullable disable

namespace Models.Models
{
    public partial class TodebFinalDBContext : DbContext
    {
        private IConfiguration _configuration;
        public TodebFinalDBContext()
        {

        }
        public TodebFinalDBContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //public TodebFinalDBContext(DbContextOptions<TodebFinalDBContext> options)
        //    : base(options)
        //{
        //}

        public virtual DbSet<ApartmentInfo> ApartmentInfos { get; set; }
        public virtual DbSet<Due> Dues { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<UserInfo> UserInfos { get; set; }
        public virtual DbSet<UserPassword> UserPasswords { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // if (!optionsBuilder.IsConfigured)
            //{
                 //optionsBuilder.UseSqlServer("Server=DAQROO\\SQLExpress;Database=TodebFinalProjectDB;Trusted_Connection=True;");
               var conn = _configuration.GetConnectionString("MsComm");
               optionsBuilder.UseSqlServer(conn);
            //}
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
                .HasOne<UserInfo>(s => s.User)
                .WithMany(g => g.Messages)
                .HasForeignKey(s => s.UserId);

            modelBuilder.Entity<ApartmentInfo>()
                .HasOne<UserInfo>(s => s.User)
                .WithMany(g => g.ApartmentInfos)
                .HasForeignKey(s => s.UserId);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

        //    modelBuilder.Entity<ApartmentInfo>(entity =>
        //    {
        //        entity.HasKey(e => e.ApartmentId)
        //            .HasName("PK_ApartmentInfo");

        //        entity.Property(e => e.ApartmentId).HasColumnName("ApartmentID");

        //        entity.Property(e => e.Block)
        //            .IsRequired()
        //            .HasMaxLength(20)
        //            .IsFixedLength(true);

        //        entity.Property(e => e.Floor)
        //            .IsRequired()
        //            .HasMaxLength(10)
        //            .IsFixedLength(true);

        //        entity.Property(e => e.Owner).HasMaxLength(50);

        //        entity.Property(e => e.Room)
        //            .IsRequired()
        //            .HasMaxLength(15)
        //            .IsFixedLength(true);

        //        entity.Property(e => e.Status)
        //            .IsRequired()
        //            .HasMaxLength(5)
        //            .IsFixedLength(true);

        //        entity.Property(e => e.Type)
        //            .IsRequired()
        //            .HasMaxLength(15)
        //            .IsFixedLength(true);

        //        entity.Property(e => e.UserId).HasColumnName("UserID");

        //        entity.HasOne(d => d.User)
        //            .WithMany(p => p.ApartmentInfos)
        //            .HasForeignKey(d => d.UserId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_ApartmentsUserInfo");
        //    });

        //    modelBuilder.Entity<Due>(entity =>
        //    {
        //        entity.Property(e => e.DueId).HasColumnName("DueID");

        //        entity.Property(e => e.ApartmentId).HasColumnName("ApartmentID");

        //        entity.Property(e => e.Date).HasColumnType("date");

        //        entity.Property(e => e.Price).HasColumnType("money");

        //        entity.HasOne(d => d.Apartment)
        //            .WithMany(p => p.Dues)
        //            .HasForeignKey(d => d.ApartmentId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_DuesApartment");
        //    });

        //    modelBuilder.Entity<Invoice>(entity =>
        //    {
        //        entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

        //        entity.Property(e => e.ApartmentId).HasColumnName("ApartmentID");

        //        entity.Property(e => e.Date).HasColumnType("date");

        //        entity.Property(e => e.Price).HasColumnType("money");

        //        entity.Property(e => e.Type)
        //            .IsRequired()
        //            .HasMaxLength(20)
        //            .IsFixedLength(true);

        //        entity.HasOne(d => d.Apartment)
        //            .WithMany(p => p.Invoices)
        //            .HasForeignKey(d => d.ApartmentId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_InvoicesApartment");
        //    });

        //    modelBuilder.Entity<Message>(entity =>
        //    {
        //        entity.Property(e => e.MessageId)
        //            .ValueGeneratedNever()
        //            .HasColumnName("MessageID");

        //        entity.Property(e => e.SendTime).HasColumnType("datetime");

        //        entity.Property(e => e.Status)
        //            .IsRequired()
        //            .HasMaxLength(15)
        //            .IsFixedLength(true);

        //        entity.Property(e => e.Text).IsRequired();

        //        entity.Property(e => e.UserId).HasColumnName("UserID");

        //        entity.HasOne(d => d.User)
        //            .WithMany(p => p.Messages)
        //            .HasForeignKey(d => d.UserId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_MessagesUser");
        //    });

        //    modelBuilder.Entity<UserInfo>(entity =>
        //    {
        //        entity.HasKey(e => e.UserId)
        //            .HasName("PK_UserInfo");

        //        entity.Property(e => e.UserId).HasColumnName("UserID");

        //        entity.Property(e => e.CarInfo).HasMaxLength(30);

        //        entity.Property(e => e.Email)
        //            .IsRequired()
        //            .HasMaxLength(50);

        //        entity.Property(e => e.IdentityNumber)
        //            .IsRequired()
        //            .HasMaxLength(11)
        //            .IsFixedLength(true);

        //        entity.Property(e => e.NameSurname)
        //            .IsRequired()
        //            .HasMaxLength(50);

        //        entity.Property(e => e.Phone)
        //            .IsRequired()
        //            .HasMaxLength(15)
        //            .IsFixedLength(true);
        //    });

        //    OnModelCreatingPartial(modelBuilder);
        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
