using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ru.emlsoft.data.ef;
using ru.emlsoft.health.model.Clinic;
using System;
using System.Linq;

namespace ru.emlsoft.health.model
{
    internal class DataModel : DbContext, IDataModel
    {
        readonly string? _error;
        readonly bool _inited;
        private readonly ILogger<DataModel> _logger;
        protected readonly string _connectionString;


        public DataModel(string connectionString, ILogger<DataModel> logger)
        {
            _connectionString = connectionString;
            _logger = logger;

            try
            {
                // if( Database.CompatibleWithModel(true))
                //    Database.EnsureDeleted();

                Database.EnsureCreated();
                

                _inited = true;
            }
            catch (Exception ex)
            {
                _inited = false;
                _error = ex.Message;
                _logger.LogError(ex, "connectionString string= {_connectionString}", _connectionString);
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DoctorState>().Property(x => x.Name).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<DoctorState>().HasIndex(x => x.Name);

            modelBuilder.Entity<Education>().Property(x => x.Name).IsRequired().IsUnicode(true).HasMaxLength(200);
            modelBuilder.Entity<Education>().Property(x => x.Description).IsUnicode(true).HasMaxLength(2000);
            modelBuilder.Entity<Education>().HasIndex(x => x.DoctorId);

            modelBuilder.Entity<Experience>().HasIndex(x => new { x.DoctorId, x.FromDate });
            modelBuilder.Entity<Experience>().HasIndex(x => new { x.ClinicId, x.DoctorId });

            modelBuilder.Entity<Doctor>().HasMany<Education>(x => x.Educations).WithOne(x => x.Doctor).HasForeignKey(x => x.DoctorId);
            modelBuilder.Entity<Doctor>().HasMany<Experience>(x => x.Experiences).WithOne(x => x.Doctor).HasForeignKey(x => x.DoctorId);
            modelBuilder.Entity<Doctor>().HasOne(x => x.State).WithMany().HasForeignKey(x => x.StateId);

            modelBuilder.Entity<Person.Person>().Property(x => x.FirstName).HasMaxLength(200);
            modelBuilder.Entity<Person.Person>().Property(x => x.LastName).HasMaxLength(200);
            modelBuilder.Entity<Person.Person>().Property(x => x.MiddleName).HasMaxLength(200);


            modelBuilder.Entity<Clinic.Clinic>().Property(x => x.Name).IsRequired().IsUnicode(true).HasMaxLength(200);
            modelBuilder.Entity<Clinic.Clinic>().Property(x => x.Description).IsUnicode(true);
            modelBuilder.Entity<Clinic.Clinic>().HasMany(x=>x.DoctorExperiences).WithOne(x=>x.Clinic).HasForeignKey(x => x.ClinicId).IsRequired();



            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Clinic.Clinic> Clinics { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
    }
}