using Microsoft.AspNetCore.Mvc;
using NuGet.Common;
using ru.emlsoft.data;
using ru.emlsoft.health.domain.Clinic;
using ru.emlsoft.health.dto.Clinic;
using ru.emlsoft.health.model.Clinic;

namespace WebApi.Controllers;


public class ClinicController : CrudController<ClinicDto>
{
    public ClinicController(IRepository<ClinicDto> repo, ILogger<CrudController<ClinicDto>> logger) : base(repo, logger) { }


}