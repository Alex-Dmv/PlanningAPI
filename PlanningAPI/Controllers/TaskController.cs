using System.Web.Mvc;
using PlanningAPI.Services;
using PlanningAPI.Models;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PlanningAPI.Controllers
{
    
    public class TaskController : Controller
    {

        private TaskService taskService;

        public TaskController()
        {
            this.taskService = new TaskService();
        }

        // GET: Task
        [HttpGet]
 
        public ActionResult All()
        {
            return Content(JsonConvert.SerializeObject(taskService.GetAllTasks()), "application/json");
        }

        [HttpGet]
        public ActionResult Get(long id)
        {
            var task = taskService.GetTask(id);
            return Content(JsonConvert.SerializeObject(task), "application/json");
        }

        [HttpPut]
        public void Update(int id,[System.Web.Http.FromBody]Task task)
        {
            //string json = content.ToString();
            //string jsonString = jsonBody.ToString();
            //return Json(jsonString);
            //System.Console.WriteLine(jsonBody);
            //Task task = JsonConvert.DeserializeObject<Task>(json);
            if (id == task.Id)
            {
                taskService.UpdateTask(task);
            }
        }

        [HttpPost]
        public void Insert([System.Web.Http.FromBody] Task task)
        {

        }
    }
}