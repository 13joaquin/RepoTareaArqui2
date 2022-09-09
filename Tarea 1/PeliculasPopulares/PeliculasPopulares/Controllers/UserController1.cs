using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PeliculasPopulares.DAO;
using PeliculasPopulares.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PeliculasPopulares.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController1 : ControllerBase
    {
        UserDAO userDao = new UserDAO();
        // GET: api/<UserController1>
        //[HttpGet]
        //public IEnumerable<PPopulares> Get()
        //{
          //  return userDao.GetAll();
        //}

        // GET api/<UserController1>/5
        [HttpGet("{id}")]
        public IEnumerable<PPopulares> Get(int id)
        {
            return userDao.GetAll(id);
        }

        // POST api/<UserController1>
        [HttpPost]
        public string Post([FromBody] PPopulares user)
        {
            var responce = userDao.SaveDataUser(user);
            return responce;
        }

        // PUT api/<UserController1>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController1>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
