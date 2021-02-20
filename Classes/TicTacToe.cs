using System;

namespace KnotsNCrosses.Classes
{
   public class GameKnotsNCrosses {

      public void StartGame() {
         for(int i = 0; i < markArray.Length; i++) {
            markArray[i] = MarkType.F;
         }
         gameStart = true;
      }
      /*
      Check for end of game conditions
      */
      public void InputMarker( int option ) {
         option--;
         MarkType marker = (player1Turn) ? MarkType.O : MarkType.X;
         markArray[option] = marker;
      }
      public void CheckForWinningCondition() {
         MarkType marker = (player1Turn) ? MarkType.O : MarkType.X;
         //check for row 
         if( (marker == markArray[0]) && (marker == markArray[1]) && (marker == markArray[2])) {
            gameStart = false;
         }
         else if( marker == markArray[3] && marker == markArray[4] && marker == markArray[5]) {
            gameStart = false;
         }
         else if( marker == markArray[6] && marker == markArray[7] && marker == markArray[8]) {
            gameStart = false;
         }
         //check for diagonal 
         if( marker == markArray[0] && marker == markArray[4] && marker == markArray[8]) {
            gameStart = false;
         }
         else if( marker == markArray[2] && marker == markArray[4] && marker == markArray[6]) {
            gameStart = false;
         }
         //check for horizontal
         if( marker == markArray[0] && marker == markArray[3] && marker == markArray[6]) {
            gameStart = false;
         }
         else if( marker == markArray[1] && marker == markArray[4] && marker == markArray[7]) {
            gameStart = false;
         }
         else if( marker == markArray[2] && marker == markArray[5] && marker == markArray[8]) {
            gameStart = false;
         }
      }
      public void EndTurn(){
         player1Turn = !player1Turn;
      }
      public void PrintGrid () {
         Console.WriteLine(
            "---------------------------------------------------------\n" +
            markArray[0] + " | " + markArray[1] + " | " + markArray[2] + "\n" +
            markArray[3] + " | " + markArray[4] + " | " + markArray[5] + "\n" +
            markArray[6] + " | " + markArray[7] + " | " + markArray[8]  
         );   
      }
      // private char get
      public bool gameStart = true;
      private bool player1Turn = true;
      private MarkType[] markArray = new MarkType[9];
   }
}