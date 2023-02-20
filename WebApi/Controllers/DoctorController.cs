using Microsoft.AspNetCore.Mvc;
using EmlSoft.Data;
using EmlSoft.Health.Dto.Clinic;

namespace WebApi.Controllers
{
    public class DoctorController : CrudController<DoctorDto>
    {
        public DoctorController(IRepository<DoctorDto> repo, ILogger<CrudController<DoctorDto>> logger) : base(repo, logger) { }

    }
}
