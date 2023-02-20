using EmlSoft.Data;
using System;


namespace EmlSoft.Health.Domain.Medicine
{
    internal interface ITherapeutic : IKeyable
    {
        string Name { get; set; }
    }
}
