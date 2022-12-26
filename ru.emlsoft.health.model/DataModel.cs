using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ru.emlsoft.data;
using ru.emlsoft.data.ef;

namespace ru.emlsoft.health.model
{
    public class DataModel : DbContext, IDataModel
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

#pragma warning disable CS8618
        public DbSet<Clinic.Clinic> Clinics { get; set; }
#pragma warning restore CS8618
    }
}
