using System;
using KnotsNCrosses.Classes;

namespace KnotsNCrosses
{
    class Program
    {
        static void Main(string[] args)
        {
            GameKnotsNCrosses ticTacToe = new GameKnotsNCrosses();
            ticTacToe.StartGame();

            while( ticTacToe.gameStart ) {
                ticTacToe.PrintGrid();
                ticTacToe.Announcer();
                int userInput = int.Parse(Console.ReadLine());
                ticTacToe.InputMarker(userInput);
                ticTacToe.CheckForWinningCondition();
                ticTacToe.EndTurn(); 
            }
        }
    }
}
