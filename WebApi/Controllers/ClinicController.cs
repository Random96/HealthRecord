using Microsoft.AspNetCore.Mvc;
using ru.emlsoft.data;
using ru.emlsoft.data.domain;
using ru.emlsoft.health.domain.Clinic;
using ru.emlsoft.health.dto;
using ru.emlsoft.health.model.Clinic;

namespace WebApi.Controllers;


public class ClinicController : CrudController<ClinicDto, Clinic> 
{
    public ClinicController(IRepository<ClinicDto, Clinic> repo, ILogger<CrudController<ClinicDto, Clinic>> logger) : base(repo, logger) { }

    [HttpGet(Name = "GetClinic")]
    public async Task<IEnumerable<ClinicDto>> Get([FromQuery] PageParameters pageParams, CancellationToken token)
    {
        _logger.LogInformation("Start");
        var ret = await _repo.GetPageAsync(pageParams.PageNumber, pageParams.PageSize, pageParams.Filters, pageParams.Orders, token);

        if (ret == null)
            return Array.Empty<ClinicDto>();

        _logger.LogInformation("Stop");
        return ret;
    }
}