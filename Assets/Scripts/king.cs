using UnityEngine;
using System.Collections;

public class king : figure
{    //король

    public bool isCheck = false;
    public bool isMate = false;
    public string name = "king";
    public move[] P_Moves = new move[63];   // возможные шаги фигуры 


    public void PossibleMoves(int x, int z) // 8 возможных ходов + рокировка(стоит дописать)
    {
        move mv = new move();
        mv.x = x + 1;       // право-верх направление
        mv.z = z + 1;
        P_Moves[0] = mv;

        mv.x = x + 1;       // право направление
        mv.z = z;
        P_Moves[1] = mv;

        mv.x = x + 1;       // право-вниз направление
        mv.z = z - 1;
        P_Moves[2] = mv;

        mv.x = x;       // вниз направление
        mv.z = z - 1;
        P_Moves[3] = mv;

        mv.x = x - 1;       // влево-вниз направление
        mv.z = z - 1;
        P_Moves[4] = mv;

        mv.x = x - 1;       // влево направление
        mv.z = z;
        P_Moves[5] = mv;

        mv.x = x - 1;       // влево-вверх направление
        mv.z = z + 1;
        P_Moves[6] = mv;

        mv.x = x;       // вверх направление
        mv.z = z + 1;
        P_Moves[7] = mv;

    }

    

    

}
