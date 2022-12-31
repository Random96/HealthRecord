using System;
using System.Collections.Generic;
using ru.emlsoft.health.domain.Clinic;

namespace ru.emlsoft.health.dto.Clinic
{
    public class DoctorDto : PersonDto, IDoctor
    {
        public ICollection<IClinic> Clinics { get; set; }
        public ICollection<IExperience> Experiences { get; set; }
        public ICollection<IEducation> Educations { get; set; }
    }
}
