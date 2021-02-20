using System;

namespace KnotsNCrosses.Classes
{
   public class GameKnotsNCrosses {

      public void StartGame() {
         for(int i = 0; i < markArray.Length; i++) {
            markArray[i] = MarkType.Free;
         }
      }
      
      /*
      Check for end of game conditions
      */
      public void EndGame() {

      }
      private bool player1Turn;
      private MarkType[] markArray = new MarkType[9];
   }
}