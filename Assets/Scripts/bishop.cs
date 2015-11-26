using UnityEngine;
using System.Collections;

public class bishop : figure
{  // слон

    public string name = "bishop";
    public move[] P_Moves = new move[63];   // возможные шаги фигуры 


    public void PossibleMoves(int x, int z) //   28 возможных ходов
    {
        move mv = new move();   
        mv.x = x + 1;       // право-верх направление
        mv.z = z + 1;
        P_Moves[0] = mv;

        mv.x = x + 2;
        mv.z = z + 2;
        P_Moves[1] = mv;

        mv.x = x + 3;
        mv.z = z + 3;
        P_Moves[2] = mv;

        mv.x = x + 4;
        mv.z = z + 4;
        P_Moves[3] = mv;

        mv.x = x + 5;
        mv.z = z + 5;
        P_Moves[4] = mv;

        mv.x = x + 6;
        mv.z = z + 6;
        P_Moves[5] = mv;

        mv.x = x + 7;
        mv.z = z + 7;
        P_Moves[6] = mv;


        mv.x = x - 1;   // вниз-влево направление
        mv.z = z - 1;
        P_Moves[7] = mv;

        mv.x = x - 2;
        mv.z = z - 2;
        P_Moves[8] = mv;

        mv.x = x - 3;
        mv.z = z - 3;
        P_Moves[9] = mv;

        mv.x = x - 4;
        mv.z = z - 4;
        P_Moves[10] = mv;

        mv.x = x - 5;
        mv.z = z - 5;
        P_Moves[11] = mv;

        mv.x = x - 6;
        mv.z = z - 6;
        P_Moves[12] = mv;

        mv.x = x - 7;
        mv.z = z - 7;
        P_Moves[13] = mv;


        mv.x = x - 1;   // лево-вверх
        mv.z = z + 1;
        P_Moves[14] = mv;

        mv.x = x - 2;
        mv.z = z + 2;
        P_Moves[15] = mv;

        mv.x = x - 3;
        mv.z = z + 3;
        P_Moves[16] = mv;

        mv.x = x - 4;
        mv.z = z + 4;
        P_Moves[17] = mv;

        mv.x = x - 5;
        mv.z = z + 5;
        P_Moves[18] = mv;

        mv.x = x - 6;
        mv.z = z + 6;
        P_Moves[19] = mv;

        mv.x = x - 7;
        mv.z = z + 7;
        P_Moves[20] = mv;


        mv.x = x + 1;   //вправо-вниз
        mv.z = z - 1;
        P_Moves[21] = mv;

        mv.x = x + 2;
        mv.z = z - 2;
        P_Moves[22] = mv;

        mv.x = x + 3;
        mv.z = z - 3;
        P_Moves[23] = mv;

        mv.x = x + 4;
        mv.z = z - 4;
        P_Moves[24] = mv;

        mv.x = x + 5;
        mv.z = z - 5;
        P_Moves[25] = mv;

        mv.x = x + 6;
        mv.z = z - 6;
        P_Moves[26] = mv;

        mv.x = x + 7;
        mv.z = z - 7;
        P_Moves[27] = mv;
        
    }
}
