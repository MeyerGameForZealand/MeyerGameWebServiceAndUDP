using System;
using System.Collections.Generic;
using System.Text;

namespace Playerconsumer
{
    class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Lives { get; set; }

        public Player()
        {

        }

        public Player(int playerId, string playerName, int wins, int losses, int lives)
        {
            PlayerId = playerId;
            PlayerName = playerName;
            Wins = wins;
            Losses = losses;
            Lives = lives;
        }

        public override string ToString()
        {
            return $"PlayerId: {PlayerId}, PlayerName: {PlayerName}, Wins: {Wins}, Losses: {Losses}, Lives: {Lives}";
        }

    }
}
