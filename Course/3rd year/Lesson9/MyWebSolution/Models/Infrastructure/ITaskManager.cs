using Core = MyWebSolution.Models.Core;
namespace MyWebSolution.Models.Infrastructure
{
    public interface ITaskManager
    {
        List<Core.Task> GetAllTasks();
        Core.Task GetTask(Int32 taskId);
        void AddTask(Core.Task task);
        bool RemoveTask(Int32 taskId);

    }
}
