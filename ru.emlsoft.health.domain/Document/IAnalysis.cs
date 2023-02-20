using EmlSoft.Health.Domain.Clinic;
using EmlSoft.Health.Domain.Medicine;
using System;
using System.Collections.Generic;

namespace EmlSoft.Health.Domain.Document
{
    public interface IAnalysis
    {
        DateTime DateTime { get; set; }
        IPatient Patient { get; set; }
        ICollection<IIndicatorValue> Indicators { get; set; }
    }
}
