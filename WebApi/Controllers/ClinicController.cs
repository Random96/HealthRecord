using EmlSoft.Data;
using EmlSoft.Health.Dto.Clinic;

namespace WebApi.Controllers;


public class ClinicController : CrudController<ClinicDto>
{
    public ClinicController(IRepository<ClinicDto> repo, ILogger<CrudController<ClinicDto>> logger) : base(repo, logger) { }


}