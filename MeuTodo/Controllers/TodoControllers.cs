using System.Collections.Generic;
using MeuTodo.Models;
using MeuTodo.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MeuTodo.Controllers
{
    [ApiController]
    [Route("v1")]
    public class TodoControllers : ControllerBase
    {
        [HttpGet]
        [Route("todos")]
        public async Task<IActionResult> Get([FromServices] AppDbContext context)
        {
            var todos:List<Todo> = await context.Todos //DbSet<Todo>
            .AsNoTracking() //IQueryable<Todo>
            .ToListAsync(); // Task<List<...>>
            return Ok(todos);
        }
    }
}