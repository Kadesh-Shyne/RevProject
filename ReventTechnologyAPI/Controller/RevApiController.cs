using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReventTechnologyAPI.Application;
using ReventTechnologyAPI.Models;
using static ReventTechnologyAPI.DTOs.RevApiDto;
using System.Collections.Generic;

namespace ReventTechnologyAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RevApiController : ControllerBase
    {

        private readonly IRevApiRepository _revApi;
        public RevApiController(IRevApiRepository revApi)
        {
            _revApi = revApi;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromHeader]int id )
        {
            if (id == null)
                return BadRequest("Invalid request");
            var query = await _revApi.GetAllAsync(id);
            return Ok(query);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (id == 0)
                return BadRequest("Invalid Request");
            var response = await _revApi.GetRevApiByIdAsync(id);
            return Ok(response);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateNewRevApi([FromBody] CreateRevApiDto model)
        {
            if (model is null)
                return BadRequest("Invalid Request");
            var response = await _revApi.CreateRevApiAsync(model);
            return Ok(response);
        }

        [HttpDelete("delete")]
        public async Task <IActionResult> DeleteRevApiAsync([FromBody] int id)
        {
            if (id == null) return BadRequest("Invalid Request");
            var response = await _revApi.DeleteRevApiAsync(id);
            return Ok(response);    
        }

    }
}
