using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ru.emlsoft.data;
using ru.emlsoft.health.domain.Clinic;
using ru.emlsoft.health.dto;

namespace ru.emlsoft.health.model.Clinic
{
    internal class Clinic : IClinic, IKeyable
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

    }
}
