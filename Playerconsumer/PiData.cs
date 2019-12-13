﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Playerconsumer
{
    class PiData
    {
        public int PiDataId { get; set; }
        public int Player1HP { get; set; }
        public int Player2HP { get; set; }
        public int Player3HP { get; set; }
        public int Player4HP { get; set; }
        public int Player5HP { get; set; }
        public int Player6HP { get; set; }
        public int Turn { get; set; }
        public int PlayerAmount { get; set; }
        public int Winner { get; set; }

        public PiData()
        {

        }

        public PiData(int piDataId, int player1Hp, int player2Hp, int player3Hp, int player4Hp, int player5Hp, int player6Hp, int turn, int playerAmount, int winner)
        {
            PiDataId = piDataId;
            Player1HP = player1Hp;
            Player2HP = player2Hp;
            Player3HP = player3Hp;
            Player4HP = player4Hp;
            Player5HP = player5Hp;
            Player6HP = player6Hp;
            Turn = turn;
            PlayerAmount = playerAmount;
            Winner = winner;
        }
    }
}
