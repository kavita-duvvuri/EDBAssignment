using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Demo.Models;

namespace Demo.Controllers
{

    public class UserController : ApiController
    {

        User[] users = new User[]
       {
           new User { UserId = new Guid(), UserName = "Kalyani", Address = "Singapore", PhoneNumber = "96754321" , UserEmail = "k@gmail.com", Age = 46},
           new User { UserId = new Guid(), UserName = "Saritha", Address = "USA", PhoneNumber = "87639098" , UserEmail = "sa@gmail.com", Age = 40},
           new User { UserId = new Guid(), UserName = "Sita", Address = "Australia", PhoneNumber = "98431427" , UserEmail = "si@gmail.com", Age = 54},
           new User { UserId = new Guid(), UserName = "Gayatri", Address = "USA", PhoneNumber = "96321672" , UserEmail = "g@gmail.com", Age = 20},
           new User { UserId = new Guid(), UserName = "Vaishnavi", Address = "USA", PhoneNumber = "98432168" , UserEmail = "v@gmail.com", Age = 18},
           new User { UserId = new Guid(), UserName = "Rahul", Address = "Singapore", PhoneNumber = "95327125" , UserEmail = "ra@gmail.com", Age = 21},
           new User { UserId = new Guid(), UserName = "Rohit", Address = "Singapore", PhoneNumber = "91528357" , UserEmail = "ro@gmail.com", Age = 17},
           new User { UserId = new Guid(), UserName = "Ravi", Address = "Singapore", PhoneNumber = "9412765" , UserEmail = "rav@gmail.com", Age = 52},
           new User { UserId = new Guid(), UserName = "Gautam", Address = "Australia", PhoneNumber = "92754321" , UserEmail = "ga@gmail.com", Age = 28},
           new User { UserId = new Guid(), UserName = "Krithi", Address = "Australia", PhoneNumber = "99754321" , UserEmail = "kr@gmail.com", Age = 25},
       };
       // GET api/<controller>
        public IEnumerable<User> GetAllUsers()
        {
            return users;
        }

        public IHttpActionResult getUserDetails(string search)
        {

            var result = users.Where(x => x.UserEmail.StartsWith(search) || search == null).ToList();

            return Ok(result);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}