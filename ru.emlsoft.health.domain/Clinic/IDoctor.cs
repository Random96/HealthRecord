using System;
using System.Collections.Generic;
using System.Text;

namespace ru.emlsoft.health.domain.Clinic
{
    public interface IDoctor : IPerson
    {
        ICollection<IClinic> Clinics { get; set; }
        ICollection<IExperience> Experiences { get; set; }

        ICollection<IEducation> Educations { get; set; }
    }
}
