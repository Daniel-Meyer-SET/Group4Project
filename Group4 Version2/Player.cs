using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4_Version2
{
    internal class Player
    {
        string playerID;
        int movesTaken;
        bool isActive;

      public  int MovesTaken {  get; set; }
      public  string PlayerName { get; set; }
      public bool IsActive { get; set; }
        public Player() { 
            movesTaken = 0;
            isActive = false;
        
        }
         
    }
}
