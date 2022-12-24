using System;
using System.Collections.Generic;
using System.Text;

namespace ru.emlsoft.health.domain.Clinic
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
        DateTime? Birthday { get; set; }
        bool? Male { get; set; }
    }
}
