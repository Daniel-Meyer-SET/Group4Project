using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Group4_Version2
{
    /// <summary>
    /// Interaction logic for GamePage.xaml
    /// </summary>
    public partial class GamePage : Page
    {
        public GamePage()
        {
            InitializeComponent();
        }
        int playerCount = 0;
        string player1Name;
        string player2Name;
        Game game1;
        private void NameButton_Click(object sender, RoutedEventArgs e)
        {
            if (NewName.Text.Length > 0 && playerCount <2) {
                // start a new game with 2 players
            playerCount++;
                if (playerCount == 1) {
                  player1Name = NewName.Text;
                    NewName.Text = null;
                }
                if (playerCount == 2) {
                     player2Name = NewName.Text;

                    NewName.Text = null;
                    // input fields are hidden and grid is shown after players input names
                    game1 = StartNewGame(player1Name, player2Name);
                    playerTurn.Content = "Turn " + game1.player1.PlayerName;
                }

            }
            
            
        }
        private Game StartNewGame(string player1Name, string player2Name)
        {
            Game game = new Game(player1Name, player2Name);
            Board.Visibility = (Visibility.Visible);
            NameInput.Visibility = (Visibility.Collapsed);
           
            game.player1.IsActive = true;

            return game;

        }
        private void saveWinner(Player winner) {

            string connectStr = ConfigurationManager.ConnectionStrings["dbConnectStr"].ConnectionString;
            string cmdStr = "INSERT INTO gameHist(PlayerName, NumberOfMoves) VALUES(@uName, @Count)";
            using (SqlConnection con = new SqlConnection(connectStr)) {
                using (SqlCommand cmd = new SqlCommand()) { 
                cmd.Connection = con;
                cmd.CommandText = cmdStr;
                    cmd.Parameters.AddWithValue("@uName",winner.PlayerName);
                    cmd.Parameters.AddWithValue("@Count", winner.MovesTaken);

                    try {
                        con.Open();
                        cmd.ExecuteNonQuery(); 
                    } 
                    
                    catch(SqlException e)
                    {
                        
                    }
                }


            }

        }

        private void CheckWin(Player player, string boxMarker) {
            

         bool column0Match= b00.Content.ToString() == boxMarker && b01.Content.ToString()== boxMarker && b02.Content.ToString() == boxMarker && b03.Content.ToString() == boxMarker;
         bool column1Match = b10.Content.ToString() == boxMarker && b11.Content.ToString() == boxMarker && b12.Content.ToString() == boxMarker && b13.Content.ToString() == boxMarker;
         bool column2Match = b20.Content.ToString() == boxMarker && b21.Content.ToString() == boxMarker && b22.Content.ToString() == boxMarker && b23.Content.ToString() == boxMarker;
         bool column3Match = b30.Content.ToString() == boxMarker && b31.Content.ToString() == boxMarker && b32.Content.ToString() == boxMarker && b33.Content.ToString() == boxMarker;
           
            bool row0Match = b00.Content.ToString() == boxMarker && b10.Content.ToString() == boxMarker && b20.Content.ToString() == boxMarker && b30.Content.ToString() == boxMarker;
            bool row1Match = b01.Content.ToString() == boxMarker && b11.Content.ToString() == boxMarker && b21.Content.ToString() == boxMarker && b31.Content.ToString() == boxMarker;
            bool row2Match = b02.Content.ToString() == boxMarker && b12.Content.ToString() == boxMarker && b22.Content.ToString() == boxMarker && b32.Content.ToString() == boxMarker;
            bool row3Match = b03.Content.ToString() == boxMarker && b13.Content.ToString() == boxMarker && b23.Content.ToString() == boxMarker && b33.Content.ToString() == boxMarker;

            bool diagonalDown = b00.Content.ToString() == boxMarker && b11.Content.ToString() == boxMarker && b22.Content.ToString() == boxMarker && b33.Content.ToString() == boxMarker;
            bool diagonaUp = b03.Content.ToString() == boxMarker && b12.Content.ToString() == boxMarker && b21.Content.ToString() == boxMarker && b30.Content.ToString() == boxMarker;

            if (column0Match || column1Match || column2Match || column3Match || row0Match || row1Match || row2Match || row3Match || diagonalDown || diagonaUp) { 
            playerTurn.Content = player.PlayerName + " wins";
                saveWinner(player);

                // deactivate all buttons
                b00.IsHitTestVisible = false;
                b01.IsHitTestVisible = false;
                b02.IsHitTestVisible = false;
                b03.IsHitTestVisible = false;
                b10.IsHitTestVisible = false;
                b11.IsHitTestVisible = false;
                b12.IsHitTestVisible = false;
                b13.IsHitTestVisible = false;
                b20.IsHitTestVisible = false;
                b21.IsHitTestVisible = false;
                b22.IsHitTestVisible = false;
                b23.IsHitTestVisible = false;
                b30.IsHitTestVisible = false;
                b31.IsHitTestVisible = false;
                b32.IsHitTestVisible = false;
                b33.IsHitTestVisible = false;

            }
        
        }

        private void MarkSquare(object sender, RoutedEventArgs e)
        {
            var clickedSquare = sender as Button;
            clickedSquare.IsHitTestVisible= false;



            if (game1.player1.IsActive && (game1.player2.IsActive == false))
            {
                clickedSquare.Content = "X";
                game1.player1.MovesTaken++;
                playerTurn.Content = "Turn " + game1.player2.PlayerName;
                CheckWin(game1.player1,"X");
                game1.player1.IsActive = false;
                game1.player2.IsActive = true;
                

            }
            
           else if (game1.player2.IsActive && (game1.player1.IsActive == false))
            {   clickedSquare.Content = "O";
                playerTurn.Content = "Turn " + game1.player1.PlayerName;
                CheckWin(game1.player2,"O");
                game1.player2.MovesTaken++;
                game1.player1.IsActive = true;
                game1.player2.IsActive = false;
                

            }
            
        }
    } 
    
}


