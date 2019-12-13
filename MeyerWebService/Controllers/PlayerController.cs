//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Threading.Tasks;
//using MeyerWebService.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace MeyerWebService.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class PlayerController : ControllerBase
//    {
//        public SqlConnection conn = new SqlConnection();

//        public SqlCommand Command;

//        public static List<string> output = new List<string>();
//        public static string outputsingle;

//        // GET: api/Player
//        [HttpGet]
//        public List<string> GetAllPlayers()
//        {
//            conn.ConnectionString =
//                "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MeyerDatabase; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
//            conn.Open();
//            string sql = "SELECT * FROM Player";
//            Command = new SqlCommand(sql, conn);
//            var datareader = Command.ExecuteReader();
//            while (datareader.Read())
//            {

//                output.Add(datareader.GetValue(0) + " , " + datareader.GetValue(1));
//            }
//            return output;
//        }

//        // GET: api/Player/5
//        [HttpGet("{id}", Name = "Get")]
//        public string Player(int id)
//        {
//            conn.ConnectionString =
//                "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MeyerDatabase; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
//            conn.Open();
//            string sql = $"SELECT * FROM Player WHERE PlayerId = {id}";
//            var datareader = Command.ExecuteReader();
//            while (datareader.Read())
//            {

//                outputsingle = datareader.GetValue(0) + ", " + datareader.GetValue(1) + ", " + datareader.GetValue(2) + ", " + datareader.GetValue(3);
//            }
//            return outputsingle;
//        }

//        // POST: api/Player
//        [HttpPost]
//        public void PostPlayer([FromBody] Player player)
//        {
//            conn.ConnectionString =
//                "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MeyerDatabase; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
//            conn.Open();
//            string sql = $"INSERT Player Values ('{player.PlayerName}', {player.Wins}, {player.Losses})";
//            Command = new SqlCommand(sql, conn);
//            Command.ExecuteNonQuery();
//        }

//        //// PUT: api/Player/5
//        //[HttpPut("{id}")]
//        //public void UpdatePlayerLives([FromBody] Player player)
//        //{
//        //    conn.ConnectionString =
//        //        "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MeyerDatabase; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
//        //    conn.Open();
//        //    string sql = $"UPDATE Player" +
//        //                 $" Set Lives = {player.Lives}" +
//        //                 $" WHERE PlayerId = {player.PlayerId}";
//        //    Command = new SqlCommand(sql, conn);
//        //    Command.ExecuteNonQuery();
//        //}


//    }
//}
