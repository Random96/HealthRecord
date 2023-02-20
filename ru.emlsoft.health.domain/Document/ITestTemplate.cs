using EmlSoft.Health.Domain.Medicine;
using System;
using System.Collections.Generic;

namespace EmlSoft.Health.Domain
{
    public interface ITestTemplate
    {
        string Name { get; set; }
        string Description { get; set; }
        ICollection<IIndicator> Indicators { get; set; }
    }
}
