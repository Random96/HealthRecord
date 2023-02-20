using System;

namespace EmlSoft.Health.Domain.Medicine
{
    public interface IIndicator
    {
        string Name { get; set; }

        IDimention DefaultDimention { get; set; }
    }
}
