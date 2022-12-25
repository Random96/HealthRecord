using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ru.emlsoft.health.dto;

namespace ru.emlsoft.health.model
{
    public class ModelProfile : Profile
    {
        public ModelProfile()
        {
            CreateMap<Clinic.Clinic, ClinicDto>();
            CreateMap<ClinicDto, Clinic.Clinic>();
            CreateMap<Clinic.Clinic, Clinic.Clinic>();
        }
    }
}
