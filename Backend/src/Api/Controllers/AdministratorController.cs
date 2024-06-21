using Api.Interfaces;
using Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/admin")]
    [Authorize(Policy = "RequireAdministratorRole")] // fix
    public class AdministratorController : ControllerBase
    {
        private readonly IAdminRepository _repo;
        public AdministratorController(IAdminRepository adminFeature)
        {
            _repo = adminFeature;
        }

        [HttpGet("id/{id}")]
        public async Task<IActionResult> GetUserById([FromRoute] string id)
        {
            var user = await _repo.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpGet("username/{username}")]
        public async Task<IActionResult> GetUserByName([FromRoute] string username)
        {
            var user = await _repo.GetUserByUserNameAsync(username);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
