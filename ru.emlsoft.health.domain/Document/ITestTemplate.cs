using System;
using System.Collections.Generic;
using System.Text;
using ru.emlsoft.health.domain.Medicine;

namespace ru.emlsoft.health.domain
{
    public interface ITestTemplate
    {
        string Name { get; set; }
        string Description { get; set; }
        ICollection<IIndicator> Indicators { get; set; }
    }
}
