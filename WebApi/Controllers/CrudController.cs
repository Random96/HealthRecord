using Microsoft.AspNetCore.Mvc;
using ru.emlsoft.data.domain;
using ru.emlsoft.health.domain.Clinic;
using ru.emlsoft.health.dto;
using ru.emlsoft.health.model.Clinic;
using System.Runtime.CompilerServices;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CrudController<Dto, Model> : ControllerBase where Model : class, IKeyable where Dto : class
    {
        protected readonly ILogger<CrudController<Dto, Model>> _logger;
        protected readonly IRepository<Dto,Model> _repo;
        public CrudController(IRepository<Dto, Model> repo, ILogger<CrudController<Dto, Model>> logger)
        {
            _logger = logger;
            _repo = repo;
        }

    }
}
