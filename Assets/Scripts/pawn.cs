using UnityEngine;
using System.Collections;

public class pawn : figure
{    //пешка

    public bool direction; // true - white to black else reverse
    public string name = "pawn";
    public bool first_move = true; // если первый шаг пешки за игру то +1 возможный ход

     public move[] P_Moves = new move[3];   // возможные шаги фигуры 


     public void PossibleMoves(int x, int z) //   28 возможных ходов
     {
         if (colors_of_figure == 0)
         {
             move mv = new move();
             mv.x = x;      // для движения
             mv.z = z + 1;
             P_Moves[0] = mv;

             mv.x = x + 1;  // для атаки
             mv.z = z + 1;
             P_Moves[1] = mv;

             mv.x = x - 1;  // для атаки
             mv.z = z + 1;
             P_Moves[2] = mv;


             if (first_move)
             {
                 mv.x = x;  // для движения
                 mv.z = z + 2;
                 P_Moves[4] = mv;

             }
         }
         else
         {
             move mv = new move();
             mv.x = x;      // для движения
             mv.z = z - 1;
             P_Moves[0] = mv;

             mv.x = x + 1;  // для атаки
             mv.z = z - 1;
             P_Moves[1] = mv;

             mv.x = x - 1;  // для атаки
             mv.z = z - 1;
             P_Moves[2] = mv;


             if (first_move)
             {
                 mv.x = x;  // для движения
                 mv.z = z - 2;
                 P_Moves[4] = mv;

             }
         }
     }
	
}
