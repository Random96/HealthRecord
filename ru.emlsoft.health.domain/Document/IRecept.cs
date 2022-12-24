using System;
using System.Collections.Generic;
using System.Text;

namespace ru.emlsoft.health.domain.Document
{
    internal interface IRecept
    {
        DateTime Date { get; set; }
        DateTime EndDate { get; set; }


    }
}
