using EmlSoft.Data;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace EmlSoft.Health.model.Clinic
{
    internal class Doctor : Person.Person, IKeyable
    {
        public int StateId { get; set; }

        [NotMapped]
        public string StateName => State.Name;

#pragma warning disable CS8618 
        public DoctorState State { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
#pragma warning restore CS8618 
    }
}
