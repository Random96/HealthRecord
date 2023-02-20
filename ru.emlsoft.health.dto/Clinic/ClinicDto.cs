using EmlSoft.Health.Domain.Clinic;
using System;

namespace EmlSoft.Health.Dto.Clinic
{
    public class ClinicDto : IClinic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
