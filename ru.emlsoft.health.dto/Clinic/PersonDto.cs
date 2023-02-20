using EmlSoft.Data;
using EmlSoft.Health.Domain.Clinic;
using System;

namespace EmlSoft.Health.Dto.Clinic
{
    public class PersonDto : IPerson, IKeyable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime? Birthday { get; set; }
        public bool? Male { get; set; }
    }
}
