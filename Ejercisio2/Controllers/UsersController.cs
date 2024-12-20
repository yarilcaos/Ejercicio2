using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ejercisio2.Models;
using Ejercisio2.Repository;

namespace Ejercisio2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly Ejercicio2Context _context;
        private GenericRepository<User> _user_repo;
        public UsersController(Ejercicio2Context context)
        {
            _context = context;
            _user_repo=new GenericRepository<User>(_context);
        }

        [HttpGet(Name = "GetUsers")]
        public IEnumerable<User> Get()
        {
            return _user_repo.Get().ToArray();
        }

        [HttpGet("{id}", Name = "GetById")]
        public User GetUserById(string id)
        {
            return _user_repo.GetByID(Guid.Parse(id));
        }
        [HttpPost(Name = "Create")]
        public void Post(string email, string name)
        {
            _user_repo.Insert(new Models.User()
            {
                UserId=Guid.NewGuid(),
                UserEmail=email,
                UserName= name
            });
            _user_repo.Save();
        }

        [HttpPatch("{id}",Name = "Update")]
        public void Update(string id,string email, string name)
        {
            var updated_user = _user_repo.GetByID(Guid.Parse(id));
            updated_user.UserName=name;
            updated_user.UserEmail=email;
            _user_repo.Update(updated_user);
            _user_repo.Save();
        }

        [HttpDelete("{id}",Name = "Delete")]
        public void Delete(string id)
        {
            _user_repo.Delete(_user_repo.GetByID(Guid.Parse(id)));
            _user_repo.Save();
        }
        
    }
}
