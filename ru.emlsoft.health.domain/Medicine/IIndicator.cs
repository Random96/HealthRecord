using System;
using System.Collections.Generic;
using System.Text;

namespace ru.emlsoft.health.domain.Medicine
{
    public interface IIndicator
    {
        string Name { get; set; }

        IDimention DefaultDimention { get; set; }
    }
}
