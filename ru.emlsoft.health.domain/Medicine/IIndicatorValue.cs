using System;
using System.Collections.Generic;
using System.Text;

namespace ru.emlsoft.health.domain.Medicine
{
    public interface IIndicatorValue
    {
        IIndicator Indicator { get; set; }
        IDimention Dimention { get; set; }
        decimal Value { get; set; }
    }
}
