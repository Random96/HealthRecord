﻿using ru.emlsoft.data;
using ru.emlsoft.health.domain.Clinic;
using System;
using System.Linq;

namespace ru.emlsoft.health.model.Clinic
{
    internal class Clinic : IClinic, IKeyable
    {
        public int Id { get; set; }
#pragma warning disable CS8618 
        public string Name { get; set; }
        public string Description { get; set; }
        virtual public ICollection<Experience> DoctorExperiences { get; set; }
#pragma warning restore CS8618 
    }
}
