using Microsoft.AspNetCore.Mvc;
using ru.emlsoft.data;
using ru.emlsoft.health.dto;

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

        [HttpGet]
        public async Task<IEnumerable<Dto>> Get([FromQuery] PageParameters pageParams, CancellationToken token = default)
        {
            _logger.LogInformation("Get page {0}. Row in page {1} - Start", pageParams.PageNumber, pageParams.PageSize);

            var ret = await _repo.GetPageAsync(pageParams.PageNumber, pageParams.PageSize, pageParams.Filters, pageParams.Orders, token);

            if (ret == null)
                return Array.Empty<Dto>();

            _logger.LogInformation("Get page {0}. Row in page {1} - Stop", pageParams.PageNumber, pageParams.PageSize);

            return ret;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Dto>> GetTodoItem(int id, CancellationToken token = default)
        {
            var item = await _repo.GetByIdAsync(id, token);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Dto item, CancellationToken token = default)
        {
            try
            {
                item = await _repo.UpdateAsync(id, item, token);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult<Dto>> Create(Dto item, CancellationToken token = default)
        {
            try
            {
                item = await _repo.UpdateAsync(item, token);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(item);
        }

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(int id, CancellationToken token = default)
        {
            try
            {
                await _repo.DeleteAsync(id, token);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error on delete Item id={0}", id);
                return new BadRequestResult();
            }

            return NoContent();
        }
    }
}
