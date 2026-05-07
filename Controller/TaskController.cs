using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TaskManager.Data;
using TaskManager.Entities;
using TaskManager.Models;

namespace TaskManager.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TaskController(TaskManagerDbContext context) : ControllerBase
    {
        private User getCurrentUser()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId is null)
                return null;
            return context.Users
                .Include(u => u.Tasks)
                .FirstOrDefault(u => u.Id == Guid.Parse(userId));
        }

        [HttpPost]
        public IActionResult createTask(CreateTaskTableDto request)
        {
            var user = getCurrentUser();
            if (user is null)
                return Unauthorized();

            var task = new TaskTable
            {
                TaskTitle = request.Title,
                TaskDescription = request.Description,
                TaskCategory = request.Category,
                Status = request.Status,
                UserId = user.Id
            };

            user.Tasks.Add(task);
            context.SaveChanges();
            return Ok(task);
        }
        [HttpPost("edit-task{id}")]
        public IActionResult updateTask(Guid id, UpdateTaskTableDto request)
        {
            var task = context.Tasks.FirstOrDefault(t => t.Id == id);
            if (task is null)
                return NotFound("Task not found");
            task.TaskTitle = request.Title;
            task.TaskDescription = request.Description;
            task.TaskCategory = request.Category;
            task.Status = request.Status;
            context.SaveChanges();
            return Ok(task);
        }
        [HttpGet("get-by-id{id}")]
        public IActionResult getTaskById(Guid id)
        {
            var task = context.Tasks.FirstOrDefault(t => t.Id == id);
            if (task is null)
                return NotFound("Task not found");
            return Ok(task);

        }
        [HttpGet("get-all")]
        public IActionResult getAllTasks()
        {
            var user = getCurrentUser();
            if (user is null)
                return Unauthorized();
            return Ok(user.Tasks);
        }
        [HttpDelete("{id}")]
        public IActionResult deleteTask(Guid id) {
            var task = context.Tasks.FirstOrDefault(t => t.Id == id);
            if (task is null)
                return NotFound("Task not found");
            context.Tasks.Remove(task);
            context.SaveChanges();
            return Ok("Deleted");

        }


      
    }
}
