using System;
using System.Collections.Generic;
using System.Text;
using ru.emlsoft.health.domain.Clinic;
using ru.emlsoft.health.domain.Medicine;

namespace ru.emlsoft.health.domain.Document
{
    public interface ITest
    {
        IClinic Clinic { get; set; }
        DateTime Date { get; set; }
        DateTime DateComplete { get; set; }
        ICollection<IIndicatorValue> Indicators { get; set; }
    }
}
