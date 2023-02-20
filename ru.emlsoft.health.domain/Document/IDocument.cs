
using EmlSoft.Data;
using System;

namespace EmlSoft.Health.Domain.Document
{
    public interface IDocument : IKeyable
    {
        DateTime Date { get; set; }

        int ClinicId { get; set; }
    }
}
