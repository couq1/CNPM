using Microsoft.AspNetCore.Mvc;
using CNPM_QBCA.Models;
using CNPM_QBCA.Services;

namespace CNPM_QBCA.Controllers
{
    public class TaskController : Controller
    {
        private readonly TaskService _taskService;

        public TaskController()
        {
            _taskService = new TaskService();
        }

        // GET: /Task/MyTasks
        public IActionResult MyTasks()
        {
            var task = _taskService.GetTasksForUser("Lecturer A"); // Sau này thay bằng User.Identity.Name
            return View(task);
        }

        // GET: /Task/Details/5
        public IActionResult Details(int id)
        {
            var task = _taskService.GetTaskById(id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        // POST: /Task/UpdateStatus
        [HttpPost]
        public IActionResult UpdateStatus(int id, string newStatus)
        {
            _taskService.UpdateTaskStatus(id, newStatus);
            return RedirectToAction("MyTasks");
        }
    }
}
