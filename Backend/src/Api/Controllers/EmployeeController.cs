using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/employee")]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        
    }
}
