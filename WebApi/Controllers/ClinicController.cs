using Microsoft.AspNetCore.Mvc;
using NuGet.Common;
using ru.emlsoft.data;
using ru.emlsoft.health.domain.Clinic;
using ru.emlsoft.health.dto;
using ru.emlsoft.health.model.Clinic;

namespace WebApi.Controllers;


public class ClinicController : CrudController<ClinicDto, Clinic>
{
    public ClinicController(IRepository<ClinicDto, Clinic> repo, ILogger<CrudController<ClinicDto, Clinic>> logger) : base(repo, logger) { }


}