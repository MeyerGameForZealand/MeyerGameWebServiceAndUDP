using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeyerWebService.Models
{
    public class Die
    {
        //Properties for the class Die.
        public int ThrowId { get; set; }
        public int LeftDie { get; set; }
        public int RightDie { get; set; }
        public int LeftCheatDie { get; set; }
        public int RightCheatDie { get; set; }


        /// <summary>
        /// Empty Constructor
        /// </summary>
        public Die()
        {
            
        }

        /// <summary>
        /// Constructor setting all properties for the class PiData.
        /// </summary>
        /// <param name="throwId"></param>
        /// <param name="leftDie"></param>
        /// <param name="rightDie"></param>
        /// <param name="leftCheatDie"></param>
        /// <param name="rightCheatDie"></param>
        public Die(int throwId, int leftDie, int rightDie, int leftCheatDie, int rightCheatDie)
        {
            ThrowId = throwId;
            LeftDie = leftDie;
            RightDie = rightDie;
            LeftCheatDie = leftCheatDie;
            RightCheatDie = rightCheatDie;
        }

    }
}
