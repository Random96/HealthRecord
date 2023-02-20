using System;

namespace EmlSoft.Health.Domain.Clinic
{
    public interface IExperience
    {
        string ClinicName { get; }
        int ClinicId { get; }
        DateTime FromDate { get; }
        DateTime? ToDate { get; }
        string Description { get; }
    }
}