using UnityEngine;
using System.Collections;

public class knight : figure
{   //конь

    
    public string name = "knight";
    public bool ischeck = false;

     public move[] P_Moves = new move[7];   // возможные шаги фигуры 


     public void PossibleMoves(int x, int z) //   28 возможных ходов
     {

         move mv = new move();
         mv.x = x - 2;     
         mv.z = z + 1;
         P_Moves[0] = mv;

         mv.x = x - 1;       
         mv.z = z + 2;
         P_Moves[1] = mv;

         mv.x = x + 1;       
         mv.z = z + 2;
         P_Moves[2] = mv;

         mv.x = x + 2;      
         mv.z = z + 1;
         P_Moves[3] = mv;

         mv.x = x + 2;      
         mv.z = z - 1;
         P_Moves[4] = mv;

         mv.x = x + 1;     
         mv.z = z - 2;
         P_Moves[5] = mv;

         mv.x = x - 1;
         mv.z = z - 2;
         P_Moves[6] = mv;

         mv.x = x - 2;
         mv.z = z - 1;
         P_Moves[7] = mv;


     }
	
}
