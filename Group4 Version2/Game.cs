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
        public  Player player1;
        public Player player2;


        public Game(string player1Name, string player2Name) {
            player1 = new Player();
            player1.PlayerName = player1Name;
            player2 = new Player();
            player2.PlayerName = player2Name;

        }



        
    }
}
