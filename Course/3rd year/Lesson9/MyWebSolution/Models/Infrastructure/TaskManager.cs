using Core = MyWebSolution.Models.Core;
using MyWebSolution.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace MyWebSolution.Models.Infrastructure
{
    public class TaskManager : ITaskManager
    {
        private readonly TaskDbContext _context;

        public TaskManager(TaskDbContext context) => _context = context;

        public List<Core.Task> GetAllTasks()
        {
            return _context.Tasks.ToList();
        }

        public Core.Task GetTask(Int32 taskId)
        {
            return _context.Tasks.FirstOrDefault(s => s.Id == taskId);
        }

        public void AddTask(Core.Task task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public bool RemoveTask(Int32 taskId)
        {
            bool isRemove = _context.Tasks.Any(s => s.Id == taskId);
            if (isRemove)
            {
                _context.Tasks.Remove(GetTask(taskId));
                _context.SaveChanges();
            }
            return isRemove;
        }
    }
}
