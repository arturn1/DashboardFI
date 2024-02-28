using System.Net;
using Domain.Commands;
using Domain.Entities;
using Domain.Handlers;
using Domain.Repositories;
using Application.Dictionary;
using API.Controllers.Contract;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsController : BaseController
    {
        private readonly IApplicationsRepository _ApplicationsRepository;
        public ApplicationsController(IApplicationsRepository ApplicationsRepository, DefaultDictionary defaultDictionary) : base(defaultDictionary)
        {
            _ApplicationsRepository = ApplicationsRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var models = await _ApplicationsRepository.GetAllAsync();

            return Ok(new CommandResult(models, HttpStatusCode.OK));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var models = await _ApplicationsRepository.GetByIdAsync(id);
            if (models == null) return NotFound(_defaultDictionary.Response["NotFound"]); 

            return Ok(new CommandResult(models, HttpStatusCode.OK));
        }

        [HttpPost]
        public async Task<IActionResult> CreateApplicationsAsync([FromBody] CreateApplicationsCommand command, [FromServices] ApplicationsHandler handler)
        {
            var handle = await handler.Handle(command);

            return Ok(handle);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateApplicationsAsync([FromBody] UpdateApplicationsCommand command, [FromServices] ApplicationsHandler handler)
        {
            var handle = await handler.Handle(command);

            return Ok(handle);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteByIdAsync(Guid id)
        {
            var entity = await _ApplicationsRepository.GetByIdAsync(id);
            if (entity == null) return NotFound(_defaultDictionary.Response["NotFound"]); 
                
            _ApplicationsRepository.DeleteObject(entity);

            var result = new { data = "Removed success!!!" };

            return Ok(new CommandResult(result, HttpStatusCode.NoContent));
        }
    }
}