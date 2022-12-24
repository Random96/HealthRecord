using ru.emlsoft.health.domain.Document;
using System;
using System.Collections.Generic;

namespace ru.emlsoft.health.domain.Clinic
{
    public interface IPatient : IPerson
    {
        ICollection<ITest> Tests { get; set; }

        ICollection<Document.IDocument> Documents { get; set; }
    }
}
