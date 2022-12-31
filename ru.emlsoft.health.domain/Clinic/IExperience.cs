using System;
using System.Collections.Generic;
using System.Text;

namespace ru.emlsoft.health.domain.Clinic
{
    public interface IExperience
    {
        IClinic Clinic { get; set; }

        DateTime FromDate { get; set; }
        DateTime ToDate { get; set; }
        string Description { get; set; }
    }
}
