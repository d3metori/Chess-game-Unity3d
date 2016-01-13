using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Сделано студентом Группы П-304 Терентьевым Дмитрием

public class king : figure
{    //король

    public bool isCheck = false;
    public bool isMate = false;
    public string name = "king";

    public List<move> P_Moves = new List<move>();   // возможные шаги фигуры 


    public void PossibleMoves(int z, int x) // 8 возможных ходов + рокировка(стоит дописать)
    {
        move mv = new move();
        mv.x = x + 1;       // право-верх направление
        mv.z = z + 1;
        if (mv.x >= 0 & mv.x < 8 & mv.z >= 0 & mv.z < 8)   // строчка для ограничения хода в границах 8x8 
        P_Moves.Add(mv);


        move mv1 = new move();
        mv1.x = x + 1;       // право направление
        mv1.z = z;
        if (mv1.x >= 0 & mv1.x < 8 & mv1.z >= 0 & mv1.z < 8)   // строчка для ограничения хода в границах 8x8 
        P_Moves.Add(mv1);

        move mv2 = new move();
        mv2.x = x + 1;       // право-вниз направление
        mv2.z = z - 1;
        if (mv2.x >= 0 & mv2.x < 8 & mv2.z >= 0 & mv2.z < 8)   // строчка для ограничения хода в границах 8x8 
        P_Moves.Add(mv2);

        move mv3 = new move();
        mv3.x = x;       // вниз направление
        mv3.z = z - 1;
        if (mv3.x >= 0 & mv3.x < 8 & mv3.z >= 0 & mv3.z < 8)   // строчка для ограничения хода в границах 8x8 
        P_Moves.Add(mv3);

        move mv4 = new move();
        mv4.x = x - 1;       // влево-вниз направление
        mv4.z = z - 1;
        if (mv4.x >= 0 & mv4.x < 8 & mv4.z >= 0 & mv4.z < 8)   // строчка для ограничения хода в границах 8x8 
        P_Moves.Add(mv4);

        move mv5 = new move();
        mv5.x = x - 1;       // влево направление
        mv5.z = z;
        if (mv5.x >= 0 & mv5.x < 8 & mv5.z >= 0 & mv5.z < 8)   // строчка для ограничения хода в границах 8x8 
        P_Moves.Add(mv5);

        move mv6 = new move();
        mv6.x = x - 1;       // влево-вверх направление
        mv6.z = z + 1;
        if (mv6.x >= 0 & mv6.x < 8 & mv6.z >= 0 & mv6.z < 8)   // строчка для ограничения хода в границах 8x8 
        P_Moves.Add(mv6);

        move mv7 = new move();
        mv7.x = x;       // вверх направление
        mv7.z = z + 1;
        if (mv7.x >= 0 & mv7.x < 8 & mv7.z >= 0 & mv7.z < 8)   // строчка для ограничения хода в границах 8x8 
        P_Moves.Add(mv7);

    }
    

}
