using UnityEngine;
using System.Collections;

public class rook : figure  
{    //ладья

     
    public string name = "rook";

   public move[] P_Moves = new move[27];   // возможные шаги фигуры 


   public void PossibleMoves(int x, int z) //   28 возможных ходов
   {
       move mv = new move();
       mv.x = x;      
       mv.z = z + 1;
       P_Moves[0] = mv;

       mv.x = x;      
       mv.z = z + 2;
       P_Moves[1] = mv;

       mv.x = x;      
       mv.z = z + 3;
       P_Moves[2] = mv;

       mv.x = x;      
       mv.z = z + 4;
       P_Moves[3] = mv;

       mv.x = x;    
       mv.z = z + 5;
       P_Moves[4] = mv;

       mv.x = x;     
       mv.z = z + 6;
       P_Moves[5] = mv;

       mv.x = x;    
       mv.z = z + 7;
       P_Moves[6] = mv;



       mv.x = x;      
       mv.z = z - 1;
       P_Moves[0] = mv;

       mv.x = x;
       mv.z = z - 2;
       P_Moves[1] = mv;

       mv.x = x;
       mv.z = z - 3;
       P_Moves[2] = mv;

       mv.x = x;
       mv.z = z - 4;
       P_Moves[3] = mv;

       mv.x = x;
       mv.z = z - 5;
       P_Moves[4] = mv;

       mv.x = x;
       mv.z = z - 6;
       P_Moves[5] = mv;

       mv.x = x;
       mv.z = z - 7;
       P_Moves[6] = mv;



       mv.x = x - 1;
       mv.z = z;
       P_Moves[0] = mv;

       mv.x = x - 2;
       mv.z = z;
       P_Moves[1] = mv;

       mv.x = x - 3;
       mv.z = z;
       P_Moves[2] = mv;

       mv.x = x - 4;
       mv.z = z;
       P_Moves[3] = mv;

       mv.x = x - 5;
       mv.z = z;
       P_Moves[4] = mv;

       mv.x = x - 6;
       mv.z = z;
       P_Moves[5] = mv;

       mv.x = x - 7;
       mv.z = z ;
       P_Moves[6] = mv;



       mv.x = x + 1;
       mv.z = z;
       P_Moves[0] = mv;

       mv.x = x + 2;
       mv.z = z;
       P_Moves[1] = mv;

       mv.x = x + 3;
       mv.z = z;
       P_Moves[2] = mv;

       mv.x = x + 4;
       mv.z = z;
       P_Moves[3] = mv;

       mv.x = x + 5;
       mv.z = z;
       P_Moves[4] = mv;

       mv.x = x + 6;
       mv.z = z;
       P_Moves[5] = mv;

       mv.x = x + 7;
       mv.z = z;
       P_Moves[6] = mv;

   }
	
}
