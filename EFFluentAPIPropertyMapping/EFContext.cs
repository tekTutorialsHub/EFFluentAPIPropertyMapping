using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure.Annotations; 


namespace EFFluentAPIPropertyMapping
{
    public class EFContext : DbContext
    {
        public EFContext() : base("EFDatabase")
        {
            Database.SetInitializer<EFContext>(new DropCreateDatabaseAlways<EFContext>());
        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //Column Name
            modelBuilder.Entity<Employee>()
                      .Property(p => p.Name)
                      .HasColumnName("EmployeeName");

            //Column Order. Name will be the first column in Table
            modelBuilder.Entity<Employee>()
                      .Property(p => p.Name)
                      .HasColumnOrder(1);

            //Data Type 
            modelBuilder.Entity<Employee>()
                .Property(p => p.Name)
                .HasColumnType("varchar");

            modelBuilder.Entity<Employee>()
                .Property(p => p.DOB)
                .HasColumnType("Date");

            
            //Optional
            modelBuilder.Entity<Employee>()
                .Property(p => p.Address)
                .IsOptional();

            //Required
            modelBuilder.Entity<Employee>()
                .Property(p => p.Email)
                .IsOptional();


            //MaxLength
            modelBuilder.Entity<Employee>()
                .Property(p => p.Address)
                .HasMaxLength(100);


            //IsMaxLength
            modelBuilder.Entity<Employee>()
                .Property(p => p.Remark)
                .IsMaxLength();


            //IsFixedLength
            modelBuilder.Entity<Department>()
                .Property(p => p.Manager)
                .HasMaxLength(50)
                .IsFixedLength();
            
            //Ignore
            modelBuilder.Entity<Project>()
                .Ignore(e => e.NoOfEmployee);



            //HasPrecision
            modelBuilder.Entity<Project>()
                .Property(p => p.Budget)
                .HasPrecision(10, 2);

            //IsConcurrencyToken
            modelBuilder.Entity<Employee>()
                .Property(t => t.Name)
                .IsConcurrencyToken();


            //IsRowVersion
            modelBuilder.Entity<Employee>()
                .Property(t => t.RowID)
                .IsRowVersion();


            //UniCode
            modelBuilder.Entity<Employee>()
                .Property(p => p.Remark)
                .IsUnicode(true);


            //DatabaseGeneratedOption
            modelBuilder.Entity<Project>()
                .Property(p => p.ProjectID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //DatabaseGeneratedOption.Computed
            //DatabaseGeneratedOption.Identity

            //HasParameterName
            modelBuilder.Entity<Project>()
                .Property(p => p.Name)
                .HasParameterName("ProjectName");


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Project { get; set; }


    }
}
