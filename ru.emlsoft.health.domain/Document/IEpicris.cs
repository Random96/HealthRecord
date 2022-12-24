using System;
using System.Collections.Generic;
using System.Text;

namespace ru.emlsoft.health.domain.Document
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
