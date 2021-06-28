using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using Microsoft.AspNetCore.Cors;

namespace drowpdowns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  
    public class loginController : ControllerBase
    {
        private string cadena = @"server=localhost;database=nick;Uid=root;pwd=qwerty123;";
        [HttpPost]
        public IActionResult consulta(Models.auth model)
        {
            int result = 0;
            IEnumerable<Models.auth> lst = null;
            using (var db = new MySqlConnection(cadena))
            {
                var sql = @"select * from nick.usuarios";
                lst = db.Query<Models.auth>(sql);
                foreach (var item in lst)
                {
                    if(model.usuarioId == item.usuarioId && model.pass == item.pass)
                    {
                        result = 1;
                        return RedirectToAction("loby","Home");
                    }
                }

             }
            return RedirectToAction("loby");
            //result = db.Execute(sql, model); 
            //return Ok(result);
        }
            
     }

}

