using EmlSoft.Health.Domain.Clinic;
using EmlSoft.Health.Domain.Medicine;
using System;
using System.Collections.Generic;

namespace EmlSoft.Health.Domain.Document
{
    public interface ITest
    {
        IClinic Clinic { get; set; }
        DateTime Date { get; set; }
        DateTime DateComplete { get; set; }
        ICollection<IIndicatorValue> Indicators { get; set; }
    }
}
