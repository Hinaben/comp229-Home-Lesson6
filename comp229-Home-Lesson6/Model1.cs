namespace comp229_Home_Lesson6
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ContosoConnectAzure")
        {
        }

        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Enrollments> Enrollments { get; set; }
        public virtual DbSet<Students> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Courses>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Courses>()
                .HasMany(e => e.Enrollments)
                .WithRequired(e => e.Courses)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Departments>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Departments>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Departments)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Students>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Students>()
                .Property(e => e.FirstMidName)
                .IsUnicode(false);

            modelBuilder.Entity<Students>()
                .HasMany(e => e.Enrollments)
                .WithRequired(e => e.Students)
                .WillCascadeOnDelete(false);
        }
    }
}
