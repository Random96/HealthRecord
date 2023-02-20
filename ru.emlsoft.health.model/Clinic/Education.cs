using ru.emlsoft.data;
using ru.emlsoft.health.domain.Clinic;
using System;
using System.Linq;

namespace ru.emlsoft.health.model.Clinic
{
    internal class Education : IKeyable, IEducation
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
#pragma warning disable CS8618 
        public virtual Doctor Doctor { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
#pragma warning restore CS8618 
    }
}
