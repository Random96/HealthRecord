using EmlSoft.Data;
using System;
using System.Linq;

namespace EmlSoft.Health.model.Clinic
{
    internal class DoctorState : IKeyable
    {
        public int Id { get; set; }
#pragma warning disable CS8618 
        public string Name { get; set; }
#pragma warning restore CS8618 

    }
}
