using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CodeFirst.Procedure.Models
{
    public class  AppDbase : DbContext
    {
      
        public virtual DbSet<uspResult>  UspResults{ get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableDetailedErrors();
            //optionsBuilder.UseSqlServer(@"Data source=MKTIT16\\SQLEXPRESS; Initial Catalog=codefirstprocedure;Integrated Security=True;");
            optionsBuilder.UseSqlServer(@"Data source=MKTIT16\SQLEXPRESS; Initial Catalog=codefirstproceduref;Integrated Security=True;");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Class>(entity =>
        //    {
        //        entity.HasIndex(e => e.Name)
        //            .IsUnique();

        //        entity.Property(e => e.Id).HasColumnName("ID");

        //        entity.Property(e => e.Name)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<Student>(entity =>
        //    {
        //        entity.Property(e => e.Id).HasColumnName("ID");

        //        entity.Property(e => e.ClassId).HasColumnName("ClassID");

        //        entity.Property(e => e.StudentName).HasMaxLength(100);

        //        entity.Property(e => e.StudentSurname).HasMaxLength(100);

        //        entity.HasOne(d => d.Class)
        //            .WithMany(p => p.Students)
        //            .HasForeignKey(d => d.ClassId);
        //    });

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}