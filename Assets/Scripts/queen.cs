using UnityEngine;
using System.Collections;

public class queen : figure
{   // королева

    
    public string name = "queen";
    public move[] P_Moves = new move[55];   // возможные шаги фигуры 


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
        P_Moves[7] = mv;

        mv.x = x;
        mv.z = z - 2;
        P_Moves[8] = mv;

        mv.x = x;
        mv.z = z - 3;
        P_Moves[9] = mv;

        mv.x = x;
        mv.z = z - 4;
        P_Moves[10] = mv;

        mv.x = x;
        mv.z = z - 5;
        P_Moves[11] = mv;

        mv.x = x;
        mv.z = z - 6;
        P_Moves[12] = mv;

        mv.x = x;
        mv.z = z - 7;
        P_Moves[13] = mv;



        mv.x = x - 1;
        mv.z = z;
        P_Moves[14] = mv;

        mv.x = x - 2;
        mv.z = z;
        P_Moves[15] = mv;

        mv.x = x - 3;
        mv.z = z;
        P_Moves[16] = mv;

        mv.x = x - 4;
        mv.z = z;
        P_Moves[17] = mv;

        mv.x = x - 5;
        mv.z = z;
        P_Moves[18] = mv;

        mv.x = x - 6;
        mv.z = z;
        P_Moves[19] = mv;

        mv.x = x - 7;
        mv.z = z;
        P_Moves[20] = mv;



        mv.x = x + 1;
        mv.z = z;
        P_Moves[21] = mv;

        mv.x = x + 2;
        mv.z = z;
        P_Moves[22] = mv;

        mv.x = x + 3;
        mv.z = z;
        P_Moves[23] = mv;

        mv.x = x + 4;
        mv.z = z;
        P_Moves[24] = mv;

        mv.x = x + 5;
        mv.z = z;
        P_Moves[25] = mv;

        mv.x = x + 6;
        mv.z = z;
        P_Moves[26] = mv;

        mv.x = x + 7;
        mv.z = z;
        P_Moves[27] = mv;

        //

        mv.x = x + 1;       // право-верх направление
        mv.z = z + 1;
        P_Moves[28] = mv;

        mv.x = x + 2;
        mv.z = z + 2;
        P_Moves[29] = mv;

        mv.x = x + 3;
        mv.z = z + 3;
        P_Moves[30] = mv;

        mv.x = x + 4;
        mv.z = z + 4;
        P_Moves[31] = mv;

        mv.x = x + 5;
        mv.z = z + 5;
        P_Moves[32] = mv;

        mv.x = x + 6;
        mv.z = z + 6;
        P_Moves[33] = mv;

        mv.x = x + 7;
        mv.z = z + 7;
        P_Moves[34] = mv;


        mv.x = x - 1;   // вниз-влево направление
        mv.z = z - 1;
        P_Moves[35] = mv;

        mv.x = x - 2;
        mv.z = z - 2;
        P_Moves[36] = mv;

        mv.x = x - 3;
        mv.z = z - 3;
        P_Moves[37] = mv;

        mv.x = x - 4;
        mv.z = z - 4;
        P_Moves[38] = mv;

        mv.x = x - 5;
        mv.z = z - 5;
        P_Moves[39] = mv;

        mv.x = x - 6;
        mv.z = z - 6;
        P_Moves[40] = mv;

        mv.x = x - 7;
        mv.z = z - 7;
        P_Moves[41] = mv;


        mv.x = x - 1;   // лево-вверх
        mv.z = z + 1;
        P_Moves[42] = mv;

        mv.x = x - 2;
        mv.z = z + 2;
        P_Moves[43] = mv;

        mv.x = x - 3;
        mv.z = z + 3;
        P_Moves[44] = mv;

        mv.x = x - 4;
        mv.z = z + 4;
        P_Moves[45] = mv;

        mv.x = x - 5;
        mv.z = z + 5;
        P_Moves[46] = mv;

        mv.x = x - 6;
        mv.z = z + 6;
        P_Moves[47] = mv;

        mv.x = x - 7;
        mv.z = z + 7;
        P_Moves[48] = mv;


        mv.x = x + 1;   //вправо-вниз
        mv.z = z - 1;
        P_Moves[49] = mv;

        mv.x = x + 2;
        mv.z = z - 2;
        P_Moves[50] = mv;

        mv.x = x + 3;
        mv.z = z - 3;
        P_Moves[51] = mv;

        mv.x = x + 4;
        mv.z = z - 4;
        P_Moves[52] = mv;

        mv.x = x + 5;
        mv.z = z - 5;
        P_Moves[53] = mv;

        mv.x = x + 6;
        mv.z = z - 6;
        P_Moves[54] = mv;

        mv.x = x + 7;
        mv.z = z - 7;
        P_Moves[55] = mv;



    }
 
}
