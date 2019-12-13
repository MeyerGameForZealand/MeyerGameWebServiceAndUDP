using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeyerWebService.Models
{
    public class Player
    {
        //Properties for the class Player.
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Lives { get; set; }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public Player()
        {

        }

        /// <summary>
        /// Constructor setting all properties for the class Player.
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="playerName"></param>
        /// <param name="wins"></param>
        /// <param name="losses"></param>
        /// <param name="lives"></param>
        public Player(int playerId, string playerName, int wins, int losses, int lives)
        {
            PlayerId = playerId;
            PlayerName = playerName;
            Wins = wins;
            Losses = losses;
            Lives = lives;
        }
    }
}
