using System;

namespace EmlSoft.Health.Domain.Document
{
    internal interface IRecept
    {
        DateTime Date { get; set; }
        DateTime EndDate { get; set; }


    }
}
