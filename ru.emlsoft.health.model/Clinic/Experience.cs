using ru.emlsoft.data;
using ru.emlsoft.health.domain.Clinic;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ru.emlsoft.health.model.Clinic
{
    internal class Experience : IKeyable, IExperience
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
#pragma warning disable CS8618 
        public virtual Doctor Doctor { get; set; }
        public int ClinicId { get; set; }
        public virtual Clinic Clinic { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Description { get; set; }
#pragma warning restore CS8618 

        [NotMapped]
        public string ClinicName => Clinic.Name;
    }
}