using System.Web.Mvc;
using PlanningAPI.Services;
using Newtonsoft.Json;

namespace PlanningAPI.Controllers
{
    public class UserController : Controller
    {
        // GET: User

        private UserService userService;

        public UserController()
        {
            this.userService = new UserService();
        }

        [HttpGet]
        public ActionResult All()
        {
            return Content(JsonConvert.SerializeObject(userService.GetAllUsers()), "application/json");
        }

        [HttpGet]
        public ActionResult Get(long id)
        {
            return Content(JsonConvert.SerializeObject(userService.GetUser(id)), "application/json");
        }
    }
}