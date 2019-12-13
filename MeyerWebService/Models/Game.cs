using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeyerWebService.Models
{
    public class Game
    {
        //Properties for the class Game.
        public int GameId { get; set; }
        public int CurrentRound { get; set; }
        public int NoOfPlayers { get; set; }
        public string Comment { get; set; }
        public int Players { get; set; }


        /// <summary>
        /// Empty Constructor.
        /// </summary>
        public Game()
        {
            
        }

        /// <summary>
        /// Constructor setting all properties for the class PiData.
        /// </summary>
        /// <param name="gameId"></param>
        /// <param name="currentRound"></param>
        /// <param name="noOfPlayers"></param>
        /// <param name="comment"></param>
        /// <param name="players"></param>
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
