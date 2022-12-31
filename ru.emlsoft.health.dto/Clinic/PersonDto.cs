using ru.emlsoft.data;
using ru.emlsoft.health.domain.Clinic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ru.emlsoft.health.dto.Clinic
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
