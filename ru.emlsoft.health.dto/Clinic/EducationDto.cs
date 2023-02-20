using ru.emlsoft.data;
using ru.emlsoft.health.domain.Clinic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ru.emlsoft.health.dto.Clinic
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
