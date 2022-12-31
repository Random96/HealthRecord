using Microsoft.AspNetCore.Mvc;
using NuGet.Common;
using ru.emlsoft.data;
using ru.emlsoft.health.domain.Clinic;
using ru.emlsoft.health.dto.Clinic;
using ru.emlsoft.health.model.Clinic;

namespace WebApi.Controllers
{
    public class DoctorController : CrudController<DoctorDto>
    {
        public DoctorController(IRepository<DoctorDto> repo, ILogger<CrudController<DoctorDto>> logger) : base(repo, logger) { }

    }
}
