using System;
using System.Collections.Generic;
using System.Text;
using ru.emlsoft.data.domain;

namespace ru.emlsoft.health.domain.Clinic
{
    public interface IClinic : IKeyable
    {
        string Name { get; set; }
        string Description { get; set; }
    }
}
