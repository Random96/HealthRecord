using ru.emlsoft.data.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ru.emlsoft.health.domain.Document
{
    public interface IDocument : IKeyable
    {
        DateTime Date { get; set; }

        int ClinicId { get; set; }
    }
}
