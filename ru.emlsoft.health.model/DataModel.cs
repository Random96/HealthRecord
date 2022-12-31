using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ru.emlsoft.data.ef;
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
                //Database.EnsureDeleted();
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
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Clinic.Clinic> Clinics { get; set; }
    }
}
