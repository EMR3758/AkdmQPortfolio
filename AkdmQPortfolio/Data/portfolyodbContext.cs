using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AkdmQPortfolio.Data;

namespace PortfolyoDbContext
{
    public partial class portfolyodbContext : DbContext
    {
        public portfolyodbContext()
        {
        }

        public portfolyodbContext(DbContextOptions<portfolyodbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AwardTable> AwardTables { get; set; } = null!;
        public virtual DbSet<CategoriesTable> CategoriesTables { get; set; } = null!;
        public virtual DbSet<ContactTable> ContactTables { get; set; } = null!;
        public virtual DbSet<EducationTable> EducationTables { get; set; } = null!;
        public virtual DbSet<HomePge> HomePges { get; set; } = null!;
        public virtual DbSet<NewsTable> NewsTables { get; set; } = null!;
        public virtual DbSet<ProfilTable> ProfilTables { get; set; } = null!;
        public virtual DbSet<ProjectsTable> ProjectsTables { get; set; } = null!;
        public virtual DbSet<ServicesTable> ServicesTables { get; set; } = null!;
        public virtual DbSet<SkillTable> SkillTables { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=portfolyodb;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AwardTable>(entity =>
            {
                entity.HasKey(e => e.AwardId);

                entity.ToTable("AwardTable");

                entity.Property(e => e.AwardId).HasColumnName("award_id");

                entity.Property(e => e.AwardName)
                    .HasMaxLength(200)
                    .HasColumnName("award_name");

                entity.Property(e => e.Organization)
                    .HasMaxLength(200)
                    .HasColumnName("organization");

                entity.Property(e => e.ProfilId).HasColumnName("ProfilID");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<CategoriesTable>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("CategoriesTable");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(100);
            });

            modelBuilder.Entity<ContactTable>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("ContactTable");

                entity.Property(e => e.ContactId).HasColumnName("contact_id");

                entity.Property(e => e.Adress)
                    .HasMaxLength(300)
                    .HasColumnName("adress");

                entity.Property(e => e.EmailPrimary)
                    .HasMaxLength(100)
                    .HasColumnName("email_primary");

                entity.Property(e => e.EmailSecondary)
                    .HasMaxLength(200)
                    .HasColumnName("email_secondary");

                entity.Property(e => e.Icon)
                    .HasMaxLength(100)
                    .HasColumnName("icon");

                entity.Property(e => e.PhonePrimary)
                    .HasMaxLength(20)
                    .HasColumnName("phone_primary");

                entity.Property(e => e.PhoneSecondary)
                    .HasMaxLength(20)
                    .HasColumnName("phone_secondary");
            });

            modelBuilder.Entity<EducationTable>(entity =>
            {
                entity.HasKey(e => e.EducationId);

                entity.ToTable("EducationTable");

                entity.Property(e => e.EducationId).HasColumnName("EducationID");

                entity.Property(e => e.Degree)
                    .HasMaxLength(200)
                    .HasColumnName("degree");

                entity.Property(e => e.EndYear).HasColumnName("end_year");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.School)
                    .HasMaxLength(200)
                    .HasColumnName("school");

                entity.Property(e => e.StartYear).HasColumnName("start_year");
            });

            modelBuilder.Entity<HomePge>(entity =>
            {
                entity.HasKey(e => e.HomeId);

                entity.ToTable("HomePge");

                entity.Property(e => e.HomeId).HasColumnName("HomeID");

                entity.Property(e => e.ImagePath).HasMaxLength(500);

                entity.Property(e => e.NameSurname).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<NewsTable>(entity =>
            {
                entity.HasKey(e => e.NewsId);

                entity.ToTable("NewsTable");

                entity.Property(e => e.NewsId).HasColumnName("news_id");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.PublishDate)
                    .HasColumnType("date")
                    .HasColumnName("publish_date");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<ProfilTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProfilTable");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("description");

                entity.Property(e => e.FullName)
                    .HasMaxLength(200)
                    .HasColumnName("full_name");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(200)
                    .HasColumnName("job_title");

                entity.Property(e => e.ProfilId).HasColumnName("ProfilID");
            });

            modelBuilder.Entity<ProjectsTable>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.ToTable("ProjectsTable");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Image)
                    .HasMaxLength(500)
                    .HasColumnName("image");

                entity.Property(e => e.ProjectName).HasMaxLength(200);

                entity.Property(e => e.ProjectTitle).HasMaxLength(100);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProjectsTables)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_ProjectsTable_CategoriesTable");
            });

            modelBuilder.Entity<ServicesTable>(entity =>
            {
                entity.HasKey(e => e.ServicesId);

                entity.ToTable("ServicesTable");

                entity.Property(e => e.ServicesId).HasColumnName("ServicesID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Icon).HasMaxLength(600);

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<SkillTable>(entity =>
            {
                entity.HasKey(e => e.SkillId);

                entity.ToTable("SkillTable");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
