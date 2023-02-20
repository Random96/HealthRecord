using EmlSoft.Data;
using EmlSoft.Health.Domain.Clinic;
using System;

namespace EmlSoft.Health.Dto.Clinic
{
    internal class EducationDto : IKeyable, IEducation
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
#pragma warning disable CS8618 
        public string Name { get; set; }
        public string Description { get; set; }
#pragma warning restore CS8618 
    }
}
