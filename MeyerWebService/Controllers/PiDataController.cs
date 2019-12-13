using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using MeyerWebService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MeyerWebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PiDataController : ControllerBase
    {
        //Variables for SQL connection and SQL string. 
        public SqlConnection conn = new SqlConnection();
        public SqlCommand Command;
        public static string outputsingle;


        //The GET method for all PiData.
        // GET: api/PiData
        [HttpGet]
        public string GetAllPiData()
        {
            conn.ConnectionString =
                "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MeyerDatabase; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            conn.Open();
            string sql = "SELECT * FROM PiData";
            Command = new SqlCommand(sql, conn);
            var datareader = Command.ExecuteReader();
            while (datareader.Read())
            {

                outputsingle = datareader.GetValue(0) + " " +
                               datareader.GetValue(1) + " " +
                               datareader.GetValue(2) + " " +
                               datareader.GetValue(3) + " " +
                               datareader.GetValue(4) + " " +
                               datareader.GetValue(5) + " " +
                               datareader.GetValue(6) + " " +
                               datareader.GetValue(7) + " " +
                               datareader.GetValue(8);
            }
            return outputsingle;
        }

        //// GET: api/PiData/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/PiData
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //The PUT method for changing the existing PiData data in the MeyerDatabase database.
        // PUT: api/PiData/5
        [HttpPut("{id}")]
        public void UpdateThrow([FromBody] PiData piData)
        {
            conn.ConnectionString =
                "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MeyerDatabase; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            conn.Open();
            string sql = $"UPDATE PiData" +
                         $" Set Player1HP={piData.Player1HP}," +
                         $" Player2HP={piData.Player2HP}," +
                         $" Player3HP={piData.Player3HP}," +
                         $" Player4HP={piData.Player4HP}," +
                         $" Player5HP={piData.Player5HP}," +
                         $" Player6HP={piData.Player6HP}," +
                         $" Turn={piData.Turn}," +
                         $" PlayerAmount={piData.PlayerAmount}," +
                         $" Winner={piData.Winner}" +
                         $" WHERE PiDataId={piData.PiDataId}";
            Command = new SqlCommand(sql, conn);
            Command.ExecuteNonQuery();
        }

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
