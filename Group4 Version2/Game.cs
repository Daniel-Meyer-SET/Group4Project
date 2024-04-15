using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4_Version2
{
    internal class Game
    {
        int totalTime;
        public int TotalTime { get {  return totalTime; } }
        


        public Game(string player1Name, string player2Name) {
            Player p1 = new Player();
            p1.PlayerID = player1Name;
            Player p2 = new Player();
            p2.PlayerID = player2Name;

        }



        
    }
}
