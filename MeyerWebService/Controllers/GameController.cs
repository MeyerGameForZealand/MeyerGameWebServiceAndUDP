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
//    public class GameController : ControllerBase
//    {
//        public SqlConnection conn = new SqlConnection();

//        public SqlCommand Command;

//        public static string outputsingle;

//        //// GET: api/Game
//        //[HttpGet]
//        //public List<string> GetAllGames()
//        //{
//        //    conn.ConnectionString =
//        //        "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MeyerDatabase; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
//        //    conn.Open();
//        //    string sql = "SELECT * FROM Game";
//        //    Command = new SqlCommand(sql, conn);
//        //    var datareader = Command.ExecuteReader();
//        //    while (datareader.Read())
//        //    {

//        //        output.Add(datareader.GetValue(0) + " , " + datareader.GetValue(4)); //opdater, hvis noOfRounds slettes fra database, eller hvis noOfRounds skal bruges på web page.
//        //    }
//        //    return output;
//        //}

//        // GET: api/Game/5
//        [HttpGet("{id}", Name = "Get")]
//        public string GetGame(int id)
//        {
//            conn.ConnectionString =
//                "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MeyerDatabase; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
//            conn.Open();
//            string sql = $"SELECT * FROM Game WHERE GameId = {id}";
//            var datareader = Command.ExecuteReader();
//            while (datareader.Read())
//            {
//                outputsingle = datareader.GetValue(0) + ", " + datareader.GetValue(1) + ", " + datareader.GetValue(2) + ", " + datareader.GetValue(3) + ", " + datareader.GetValue(4) + ", " + datareader.GetValue(5);
//            }
//            return outputsingle;
//        }

//        // POST: api/Game
//        [HttpPost]
//        public void PostGame([FromBody] Game game)
//        {
//            conn.ConnectionString =
//                "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MeyerDatabase; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
//            conn.Open();
//            string sql = $"INSERT Game Values ('{game.GameId}', {game.CurrentRound}, {game.NoOfPlayers}, {game.Comment}, {game.Players})";
//            Command = new SqlCommand(sql, conn);
//            Command.ExecuteNonQuery();
//        }

//        //// PUT: api/Game/5
//        //[HttpPut("{id}")]
//        //public void Put(int id, [FromBody] string value)
//        //{
//        //}

//        //// DELETE: api/ApiWithActions/5
//        //[HttpDelete("{id}")]
//        //public void Delete(int id)
//        //{
//        //}
//    }
//}
