using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace drowpdowns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class menuController : ControllerBase
    {
        private string cadena = @"server=localhost;database=nick;Uid=root;pwd=qwerty123;";

        [HttpGet]
        public IActionResult consulta()
        {
            IEnumerable<Models.datos> lst = null;
            using (var db = new MySqlConnection(cadena))
            {
                var sql = "select * from nick.menu";
                lst = db.Query<Models.datos>(sql);
            }
            return Ok(lst);
        }
     }
}
