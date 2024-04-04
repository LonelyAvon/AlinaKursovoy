using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Helper;

public partial class DiaryeatContext : DbContext
{
    public DiaryeatContext()
    {
    }

    public DiaryeatContext(DbContextOptions<DiaryeatContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Activity> Activities { get; set; }

    public virtual DbSet<Day> Days { get; set; }

    public virtual DbSet<Dayeat> Dayeats { get; set; }

    public virtual DbSet<Eat> Eats { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<Meal> Meals { get; set; }

    public virtual DbSet<Purpose> Purposes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("server=localhost;user id=postgres;password=1234;database=Diaryeat");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Activity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("activity_pkey");

            entity.ToTable("activity");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Day>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("days_pkey");

            entity.ToTable("days");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Carbohydrates).HasColumnName("carbohydrates");
            entity.Property(e => e.Carbohydrateseat).HasColumnName("carbohydrateseat");
            entity.Property(e => e.Ccal).HasColumnName("ccal");
            entity.Property(e => e.Ccaleat).HasColumnName("ccaleat");
            entity.Property(e => e.Datenow).HasColumnName("datenow");
            entity.Property(e => e.Fats).HasColumnName("fats");
            entity.Property(e => e.Fatseat).HasColumnName("fatseat");
            entity.Property(e => e.Proteins).HasColumnName("proteins");
            entity.Property(e => e.Proteinseat).HasColumnName("proteinseat");
            entity.Property(e => e.Uuid).HasColumnName("uuid");
            entity.Property(e => e.Water).HasColumnName("water");
            entity.Property(e => e.Weight).HasColumnName("weight");

            entity.HasOne(d => d.Uu).WithMany(p => p.Days)
                .HasForeignKey(d => d.Uuid)
                .HasConstraintName("to_user");
        });

        modelBuilder.Entity<Dayeat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("dayeat_pkey");

            entity.ToTable("dayeat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdDay).HasColumnName("id_day");
            entity.Property(e => e.IdEat).HasColumnName("id_eat");

            entity.HasOne(d => d.IdDayNavigation).WithMany(p => p.Dayeats)
                .HasForeignKey(d => d.IdDay)
                .HasConstraintName("to_day");

            entity.HasOne(d => d.IdEatNavigation).WithMany(p => p.Dayeats)
                .HasForeignKey(d => d.IdEat)
                .HasConstraintName("to_eat");
        });

        modelBuilder.Entity<Eat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("eat_pkey");

            entity.ToTable("eat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Carbohydrates).HasColumnName("carbohydrates");
            entity.Property(e => e.Ccal).HasColumnName("ccal");
            entity.Property(e => e.Fats).HasColumnName("fats");
            entity.Property(e => e.IdMeal).HasColumnName("id_meal");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Proteins).HasColumnName("proteins");
            entity.Property(e => e.Weight).HasColumnName("weight");

            entity.HasOne(d => d.IdMealNavigation).WithMany(p => p.Eats)
                .HasForeignKey(d => d.IdMeal)
                .HasConstraintName("to_meals");
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gender_pkey");

            entity.ToTable("gender");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Meal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("meals_pkey");

            entity.ToTable("meals");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Purpose>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("purpose_pkey");

            entity.ToTable("purpose");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Uuid).HasName("User_pkey");

            entity.ToTable("User");

            entity.Property(e => e.Uuid).HasColumnName("uuid");
            entity.Property(e => e.Activity).HasColumnName("activity");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.Purpose).HasColumnName("purpose");
            entity.Property(e => e.Weight).HasColumnName("weight");

            entity.HasOne(d => d.ActivityNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Activity)
                .HasConstraintName("to_activity");

            entity.HasOne(d => d.GenderNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Gender)
                .HasConstraintName("to_gender");

            entity.HasOne(d => d.PurposeNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Purpose)
                .HasConstraintName("to_purpose");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
