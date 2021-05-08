using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend;
using Backend.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public LoginController(ApplicationDBContext context)
        {
            _context = context;
        }

        

        // POST: api/Login
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            int id = 0;
          

            //Propiedades 
            string correo = user.correo;
            string password = user.password;

            var datos =  _context.UserTable.ToArray();


            //Recorro el array 
            for (int i = 0; i < datos.Length; i++)
            {
                //Verifico si los datos enviados existen en mi base de datos
                if (datos[i].correo == correo && datos[i].password == password)
                {
                    id = datos[i].id;
                }
            }

            //Retorno el usario loggeado
            var user_loggin = _context.UserTable.SingleOrDefault(user => user.id == id);
            return user_loggin;
        }
  
    }
}
