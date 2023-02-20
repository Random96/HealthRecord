using System;

namespace EmlSoft.Health.Domain.Clinic
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
