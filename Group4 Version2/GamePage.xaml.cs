using System;
using System.Collections.Generic;
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
      
        private void CheckWin() {
         bool column0Match=   b00.Content == b01.Content && b02.Content == b03.Content;
         bool column1Match = b10.Content == b11.Content && b12.Content == b13.Content;
         bool column2Match = b20.Content == b21.Content && b22.Content == b23.Content;   
         bool column3Match = b30.Content == b31.Content && b32.Content == b33.Content;
           
            bool row0Match = b00.Content == b10.Content && b20.Content == b30.Content;
            bool row1Match = b01.Content == b11.Content && b21.Content == b31.Content;
            bool row2Match = b02.Content == b12.Content && b22.Content == b32.Content;
            bool row3Match = b03.Content == b13.Content && b23.Content == b33.Content;

            bool diagonalDown = b00.Content == b11.Content && b22.Content == b33.Content;
            bool diagonaUp = b03.Content == b12.Content && b21.Content == b30.Content;

           if()
        
        }

        private void MarkSquare(object sender, RoutedEventArgs e)
        {
            var clickedSquare = sender as Button;
            clickedSquare.IsHitTestVisible= false;



            if (game1.player1.IsActive && (game1.player2.IsActive == false))
            {
                clickedSquare.Content = "X";
                game1.player1.MovesTaken++;
                
                game1.player1.IsActive = false;
                game1.player2.IsActive = true;
               
            }
            
           else if (game1.player2.IsActive && (game1.player1.IsActive == false))
            {   clickedSquare.Content = "O";
                game1.player2.MovesTaken++;
                game1.player1.IsActive = true;
                game1.player2.IsActive = false;
               
                
            }
            CheckWin();
         }
    } 
    
}


