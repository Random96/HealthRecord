using System;
using System.Collections.Generic;
using System.Text;
using ru.emlsoft.data.domain;

namespace ru.emlsoft.health.domain.Medicine
{
    internal interface ITherapeutic : IKeyable
    {
        string Name { get; set; }
    }
}
