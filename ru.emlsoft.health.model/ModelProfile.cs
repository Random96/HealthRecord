using AutoMapper;
using EmlSoft.Health.Dto.Clinic;
using System;
using System.Linq;

namespace EmlSoft.Health.model
{
    public class ModelProfile : Profile
    {
        public ModelProfile()
        {
            CreateMap<Clinic.Clinic, ClinicDto>();
            CreateMap<ClinicDto, Clinic.Clinic>();
            CreateMap<Clinic.Clinic, Clinic.Clinic>();


            CreateMap<Clinic.Doctor, DoctorDto>();
            CreateMap<DoctorDto, Clinic.Doctor>();
            CreateMap<Clinic.Doctor, Clinic.Doctor>();
        }
    }
}
