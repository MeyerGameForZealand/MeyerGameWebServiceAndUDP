using System;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Playerconsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setup of connection
            UdpClient udpClient = new UdpClient(7000);
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint remoteIpEndpoint = new IPEndPoint(IPAddress.Any, 7000);
            
            //Connection feedback string. Has no importance for the program.
            Console.WriteLine("Server is activated... maybe");

            // loop that receives data from our raspberry pi and updates the MeyerDatabase database.
            while (true)
            {
                Byte[] receivedBytes = udpClient.Receive(ref remoteIpEndpoint);
                string receiveddData = Encoding.ASCII.GetString(receivedBytes);
                string[] data = receiveddData.Split(" ");
                string turn = data[0];
                string player1HP = data[1];
                string player2HP = data[2];
                string player3HP = data[3];
                string player4HP = data[4];
                string player5HP = data[5];
                string player6HP = data[6];
                string playerAmount = data[7];
                string Winner = data[8];
                Console.WriteLine(turn);
                Console.WriteLine(player1HP);
                PutPiData(new PiData(1,Int32.Parse(player1HP), 
                    Int32.Parse(player2HP), 
                    Int32.Parse(player3HP), 
                    Int32.Parse(player4HP), 
                    Int32.Parse(player5HP), 
                    Int32.Parse(player6HP), 
                    Int32.Parse(turn), 
                    Int32.Parse(playerAmount), 
                    Int32.Parse(Winner)));
            }
        }

        //Method updating existing data in the MeyerDatabase database.
        public static async void PutPiData(PiData piData)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpContent content = new StringContent(JsonConvert.SerializeObject(piData), Encoding.UTF8, "application/json");
                var result = await client.PutAsync(@"https://localhost:44390/api/PieData/1", content);
            }
        }


        //public static async void Test(Player player)
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        HttpContent content = new StringContent(JsonConvert.SerializeObject(player), Encoding.UTF8, "application/json");
        //        var result = await client.PostAsync(@"https://localhost:44390/api/player", content);
        //    }
        //}
    }
}
