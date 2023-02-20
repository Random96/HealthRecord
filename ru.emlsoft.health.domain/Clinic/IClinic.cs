using EmlSoft.Data;
using System;


namespace EmlSoft.Health.Domain.Clinic
{
    public interface IClinic : IKeyable
    {
        string Name { get; set; }
        string Description { get; set; }
    }
}
