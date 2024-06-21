using Api.Data;
using Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/store")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreRepository _repo;
        public StoreController(IStoreRepository repo)
        {
            _repo = repo;
        }

    }
}
