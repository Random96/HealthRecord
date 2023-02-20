using System;
using System.Collections.Generic;

namespace EmlSoft.Health.Domain.Clinic
{
    public interface IDoctor : IPerson
    {
        ICollection<IClinic> Clinics { get; set; }
        ICollection<IExperience> Experiences { get; set; }

        ICollection<IEducation> Educations { get; set; }
    }
}
