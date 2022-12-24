using System;
using ru.emlsoft.health.domain.Clinic;

namespace ru.emlsoft.health.dto
{
    public class ClinicDto : IClinic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
