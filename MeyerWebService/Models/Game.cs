using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeyerWebService.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public int CurrentRound { get; set; }
        public int NoOfPlayers { get; set; }
        public string Comment { get; set; }
        public int Players { get; set; }

        public Game()
        {
            
        }

        public Game(int gameId, int currentRound, int noOfPlayers, string comment, int players)
        {
            GameId = gameId;
            CurrentRound = currentRound;
            NoOfPlayers = noOfPlayers;
            Comment = comment;
            Players = players;
        }
    }

    

}
