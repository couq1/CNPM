using Microsoft.AspNetCore.Mvc;
using CNPM_QBCA.Models;
using CNPM_QBCA.Services;

namespace CNPM_QBCA.Controllers
{
    public class MyTasksController : Controller
    {
        private readonly TaskService _taskService;

        public MyTasksController()
        {
            _taskService = new TaskService();
        }

        // GET: /MyTasks/MyTasks
        public IActionResult MyTasks()
        {
            var task = _taskService.GetTasksForUser("Lecturer A"); // Sau này thay bằng User.Identity.Name
            return View(task);
        }

        // GET: /MyTasks/Details/5
        public IActionResult Details(int id)
        {
            var task = _taskService.GetTaskById(id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        // POST: /MyTasks/UpdateStatus
        [HttpPost]
        public IActionResult UpdateStatus(int id, string newStatus)
        {
            _taskService.UpdateTaskStatus(id, newStatus);
            return RedirectToAction("MyTasks");
        }
    }
}
