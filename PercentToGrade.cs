/*------------------------------------------------------------------------------
 *                      HTBLA-Leonding / Class: 3ACIF                           
 *------------------------------------------------------------------------------
 *                      Jan Ritt                                                
 *------------------------------------------------------------------------------
 *  Description:  The program reads in the percentage of reached Points in some 
 *                test or whatever, it calculates your grade from this value,   
 *                in accordance to following table:                             
 *                exclusive infinite% to inclusive 88% = SehrGut                
 *                from above 88% to inclusive 75%      = Gut                    
 *                from above 75% to inclusive 63%      = Befriedigend           
 *                from above 63% to inclusive 50%      = Genügend               
 *                from above 50% to inclusive 0%       = Nicht Genügend         
 *                !! AND ELSE: outputs a failure message                        
 *------------------------------------------------------------------------------
*/
using System;

namespace PercentToGrade
{
  internal class Program
  {
    static void Main(string[] args)
    {
      double reachedPercent;
      // Eingabe      (E)  --  Header
      Console.Clear();
      Console.Write("\n              PercentToGrade\n");
      Console.Write("============================================\n");
      // Eingabe      (E)  --  Input
      Console.Write(" Bitte geben Sie die Prozente ein,\n die Sie erreicht haben:  ");
      reachedPercent = Convert.ToDouble(Console.ReadLine());
      // Verarbeitung (V)  --  Calculate
      Console.Write("--------------------------------------------\n");
      if (reachedPercent < 0)
      {
        Console.Write(" ! Ungültige Eingabe !\n");
      }
      else if ((reachedPercent > 0) && (reachedPercent < 50))
      {
        Console.Write(" Sie haben die Note Nicht Genügend erreicht.\n");
      }
      else if ((reachedPercent > 50) && (reachedPercent < 63))
      {
        Console.Write(" Sie haben die Note Genügend erreicht.\n");
      }
      else if ((reachedPercent > 63) && (reachedPercent < 75))
      {
        Console.Write(" Sie haben die Note Befriedigend erreicht.\n");
      }
      else if ((reachedPercent > 75) && (reachedPercent < 88))
      {
        Console.Write(" Sie haben die Note Gut erreicht.\n");
      }
      else if ((reachedPercent > 88) && (reachedPercent < 100))
      {
        Console.Write(" Sie haben die Note Sehr Gut erreicht.\n");
      }
      else
      {
        Console.Write(" ! Ungültige Eingabe !\n");
      }
      // Ausgabe      (A)  --  End
      Console.Write("--------------------------------------------\n");
      Console.Write(" Zum Beenden bitte Taste drücken ...\n");
      Console.ReadKey();
      Console.Clear();
    }
  }
}