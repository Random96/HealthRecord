using EmlSoft.Health.Domain.Clinic;
using System;
using System.Collections.Generic;

namespace EmlSoft.Health.Dto.Clinic
{
    public class DoctorDto : PersonDto, IDoctor
    {
        public ICollection<IClinic> Clinics { get; set; }
        public ICollection<IExperience> Experiences { get; set; }
        public ICollection<IEducation> Educations { get; set; }
    }
}
