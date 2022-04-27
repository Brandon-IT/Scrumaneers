using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Model
{
    public class PlayerTaskModel
    {
        public int PlayerTask_Id { get; set; }
        public int Is_Complete { get; set; }

        /// <summary>
        /// Our MySQL database uses Timestamp so a conversion from DateTime to Timestamp is needed
        /// </summary>
        public DateTime Time_Stamp { get; set; }

        public int Task_Id { get; set; }
        public int Game_Id { get; set; }
        public int Player_Id { get; set; }
    }
}
