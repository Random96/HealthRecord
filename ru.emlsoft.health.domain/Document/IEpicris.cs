using System;
using System.Collections.Generic;

namespace EmlSoft.Health.Domain.Document
{
    internal interface IEpicris : IDocument
    {
        int iDoctor { get; set; }

        // исследования
        ICollection<ITestTemplate> TestTemplates { get; set; }
        ICollection<ITest> Tests { get; set; }

        // лекарства
    }
}
