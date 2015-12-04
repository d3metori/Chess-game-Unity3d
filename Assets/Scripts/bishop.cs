using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class bishop : figure
{  // слон

    public string name = "bishop";

    public GameObject Core_object;
    public bool Can_add = true;

    public List<move> P_Moves_LeftUp = new List<move>();    // массивы для направлений
    public List<move> P_Moves_RightUp = new List<move>();
    public List<move> P_Moves_LeftDown = new List<move>();
    public List<move> P_Moves_RightDown = new List<move>();

    public void PossibleMoves(int z, int x) //   28 возможных ходов
    {
        Core_object = GameObject.Find("Core");
        Core scriptToAccess = Core_object.GetComponent<Core>();
        

        for (int i = 1; i < 8; i++)    // Вправо+Вверх
        {
            move mv = new move();
            mv.x = x + i;
            mv.z = z + i;
            if (mv.x >= 0 & mv.x < 8 & mv.z >= 0 & mv.z < 8)    // строчка для ограничения хода в границах 8x8 
            {
                if (Can_add)
                {
                    if (scriptToAccess.board[mv.z, mv.x].figure_name != "empty")
                    {
                        Can_add = false;
                        if(scriptToAccess.board[scriptToAccess.second_z,scriptToAccess.second_x].colors_of_figure == scriptToAccess.State2){   // добавляем ели цвет не наш
                        P_Moves_RightUp.Add(mv);
                        }
                    }
                }

                if (Can_add)
                {
                    P_Moves_RightUp.Add(mv);
                }
                    
                
            }
        }

        Can_add = true;

        for (int i = 1; i < 8; i++)    // Вправо+Вниз
        {
            move mv = new move();
            mv.x = x + i;
            mv.z = z - i;
            if (mv.x >= 0 & mv.x < 8 & mv.z >= 0 & mv.z < 8)    // строчка для ограничения хода в границах 8x8 
            {

                if (Can_add)
                {
                    if (scriptToAccess.board[mv.z, mv.x].figure_name != "empty")
                    {
                        Can_add = false;
                        if (scriptToAccess.board[scriptToAccess.second_z, scriptToAccess.second_x].colors_of_figure != scriptToAccess.State2)
                        {   // добавляем ели цвет не наш
                            Debug.Log("mov");
                            P_Moves_RightUp.Add(mv);
                        }
                    }
                }

                if (Can_add)
                {
                    Debug.Log("move");
                    P_Moves_RightUp.Add(mv);
                }

            }
        }

        Can_add = true;

        for (int i = 1; i < 8; i++)    // Влево+Вниз
        {
            move mv = new move();
            mv.x = x - i;
            mv.z = z - i;
            if (mv.x >= 0 & mv.x < 8 & mv.z >= 0 & mv.z < 8)    // строчка для ограничения хода в границах 8x8 
            {

                if (Can_add)
                {
                    if (scriptToAccess.board[mv.z, mv.x].figure_name != "empty")
                    {
                        Can_add = false;
                        P_Moves_RightUp.Add(mv);
                    }
                }

                if (Can_add)
                {
                    P_Moves_RightUp.Add(mv);
                }

            }
        }

        Can_add = true;

        for (int i = 1; i < 8; i++)    // Влево+Вверх
        {
            move mv = new move();
            mv.x = x - i;
            mv.z = z + i;
            if (mv.x >= 0 & mv.x < 8 & mv.z >= 0 & mv.z < 8)    // строчка для ограничения хода в границах 8x8 
            {
                if (Can_add)
                {
                    if (scriptToAccess.board[mv.z, mv.x].figure_name != "empty")
                    {
                        Can_add = false;
                        P_Moves_LeftUp.Add(mv);
                    }
                }

                if (Can_add)
                {
                    P_Moves_LeftUp.Add(mv);
                }
            }
        }

        Can_add = true;
    }
}
