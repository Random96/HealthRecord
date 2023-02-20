using System;

namespace EmlSoft.Health.Domain.Medicine
{
    public interface IIndicatorValue
    {
        IIndicator Indicator { get; set; }
        IDimention Dimention { get; set; }
        decimal Value { get; set; }
    }
}
