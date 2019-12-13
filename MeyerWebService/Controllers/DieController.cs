//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Threading.Tasks;
//using MeyerWebService.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace MeyerWebService.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class DieController : ControllerBase
//    {
//        public SqlConnection conn = new SqlConnection();

//        public SqlCommand Command;

//        public static string outputsingle;

//        //// GET: api/Die
//        //[HttpGet]
//        //public IEnumerable<string> Get()
//        //{
//        //    return new string[] { "value1", "value2" };
//        //}

//        // GET: api/Die/5
//        [HttpGet("{id}", Name = "Get")]
//        public string GetDie(int id)
//        {
//            conn.ConnectionString =
//                "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MeyerDatabase; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
//            conn.Open();
//            string sql = $"SELECT * FROM Die WHERE DieId = {id}";
//            var datareader = Command.ExecuteReader();
//            while (datareader.Read())
//            {

//                outputsingle = datareader.GetValue(0) + ", " + datareader.GetValue(1) + ", " + datareader.GetValue(2) + ", " + datareader.GetValue(3) + ", " + datareader.GetValue(4);
//            }
//            return outputsingle;
//        }

//        //// POST: api/Die
//        //[HttpPost]
//        //public void Post([FromBody] string value)
//        //{
//        //}

//        // PUT: api/Die/5
//        [HttpPut("{id}")]
//        public void UpdateThrow([FromBody] Die die)
//        {
//            conn.ConnectionString =
//                "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MeyerDatabase; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
//            conn.Open();
//            string sql = $"UPDATE Die" +
//                         $" Set LeftDie = {die.LeftDie}" +
//                         $" RightDie = {die.RightDie}" +
//                         $" LeftCheatDie = {die.LeftCheatDie}" +
//                         $" RightCheatDie = {die.RightCheatDie}" +
//                         $" WHERE ThrowId = {die.ThrowId}";
//            Command = new SqlCommand(sql, conn);
//            Command.ExecuteNonQuery();
//        }

//        //// DELETE: api/ApiWithActions/5
//        //[HttpDelete("{id}")]
//        //public void Delete(int id)
//        //{
//        //}
//    }
//}
