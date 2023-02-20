using EmlSoft.Health.Domain.Document;
using System;
using System.Collections.Generic;

namespace EmlSoft.Health.Domain.Clinic
{
    public interface IPatient : IPerson
    {
        ICollection<ITest> Tests { get; set; }

        ICollection<Document.IDocument> Documents { get; set; }
    }
}
