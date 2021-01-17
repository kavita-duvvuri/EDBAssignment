using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Demo.Models;

namespace Demo.Controllers
{
    public class UserViewController : Controller
    {
        public System.Threading.Tasks.Task<HttpResponseMessage> responseTask { get; private set; }

        // GET: UserView
        public ActionResult Index(string search)
        {
            IEnumerable<User> users = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://webapi.localhost.demo/api/");
               // var responseTask = null;
                //HTTP GET
                if (!string.IsNullOrEmpty(search))
                {
                    responseTask = client.GetAsync("User?search=" + search);
                }
                else
                {
                    responseTask = client.GetAsync("User");
                }

                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<User>>();
                    readTask.Wait();

                    users = readTask.Result;
                }
                else
                {


                    users = Enumerable.Empty<User>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(users);
           
        }
    }
}