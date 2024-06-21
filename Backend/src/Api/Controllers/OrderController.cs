using Api.Dtos.Product;
using Api.Helpers;
using Api.Models;
using Api.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/order")]
    public class OrderController : ControllerBase
    {
        private readonly OrderRepository _repo;
        public OrderController(OrderRepository repo)
        {
            _repo = repo;
        }


    }
}
