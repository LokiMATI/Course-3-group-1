using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Core = MyWebSolution.Models.Core;
using MyWebSolution.Models.DB;
using MyWebSolution.Models.Infrastructure;

namespace MyWebSolution.Controllers
{
    [Route("api/[controller]")]
    public class TaskController : Controller
    {
        private ITaskManager _taskManager;
        public TaskController(TaskDbContext context)
        {
            _taskManager = new TaskManager(context);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var Tasks = _taskManager.GetAllTasks();
            if (Tasks == null) return NotFound();
            return Ok(_taskManager.GetAllTasks);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_taskManager.GetTask(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody]Core.Task task)
        {
            _taskManager.AddTask(task);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return _taskManager.RemoveTask(id) ? Ok() : NotFound();
        }
    }
}
