using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Сделано студентом Группы П-304 Терентьевым Дмитрием

public class bishop : figure
{  // слон

    public string name = "bishop";

    public GameObject Core_object;



    public bool Can_add = true;

    public List<move> All_moves = new List<move>();

    public List<move> P_Moves_LeftUp = new List<move>();    // массивы для направлений
    public List<move> P_Moves_RightUp = new List<move>();
    public List<move> P_Moves_LeftDown = new List<move>();
    public List<move> P_Moves_RightDown = new List<move>();

    public void PossibleMoves(int z, int x) //   28 возможных ходов
    {
        Core_object = GameObject.Find("Core");
        Core scriptToAccess = Core_object.GetComponent<Core>();


        int myColor = 0;
        if (scriptToAccess.State == 1)
        {
            myColor = 0;
        }
        else
        {
            myColor = 1;
        }

        int for_z, for_x;
        for_z = z;
        for_x = x;

        

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
                        if (scriptToAccess.board[mv.z, mv.x].colors_of_figure != myColor & scriptToAccess.board[mv.z, mv.x].figure_name != "empty")
                        {   // добавляем ели цвет не наш
                        P_Moves_RightUp.Add(mv);
                  //      Debug.Log(mv.z);
                  //      Debug.Log(mv.x);
                 //       Debug.Log("bishop");
                        break;
                        }
                    }
                }

                if (Can_add)
                {
                    if (scriptToAccess.board[mv.z, mv.x].colors_of_figure != myColor)
                    {
                        P_Moves_RightUp.Add(mv);
                        //    Debug.Log(mv.z);
                        //    Debug.Log(mv.x);
                        //    Debug.Log("bishop");
                    }
                }
                    
                
            }
        }

        z = for_z;
        x = for_x;

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
                        if (scriptToAccess.board[mv.z, mv.x].colors_of_figure != myColor & scriptToAccess.board[mv.z, mv.x].figure_name != "empty")
                        {   // добавляем ели цвет не наш
                            P_Moves_RightDown.Add(mv);
                  //          Debug.Log(mv.z);
                  //          Debug.Log(mv.x);
                  //          Debug.Log("bishop");
                            break;
                        }
                    }
                }

                if (Can_add)
                {
                    if (scriptToAccess.board[mv.z, mv.x].colors_of_figure != myColor)
                    {
                        //      Debug.Log(mv.z);
                        //      Debug.Log(mv.x);
                        //      Debug.Log("bishop");
                        P_Moves_RightDown.Add(mv);
                    }
                }

            }
        }

        z = for_z;
        x = for_x;

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
                        if (scriptToAccess.board[mv.z, mv.x].colors_of_figure != myColor & scriptToAccess.board[mv.z, mv.x].figure_name != "empty")
                        {   // добавляем ели цвет не наш
                            P_Moves_LeftDown.Add(mv);
                //            Debug.Log(mv.z);
                //            Debug.Log(mv.x);
                //            Debug.Log("bishop");
                            break;
                        }
                    }
                }

                if (Can_add)
                {
                    if (scriptToAccess.board[mv.z, mv.x].colors_of_figure != myColor)
                    {
                        //     Debug.Log(mv.z);
                        //     Debug.Log(mv.x);
                        //     Debug.Log("bishop");
                        P_Moves_LeftDown.Add(mv);
                    }
                }
            }
        }

        z = for_z;
        x = for_x;

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
                        if (scriptToAccess.board[mv.z, mv.x].colors_of_figure != myColor & scriptToAccess.board[mv.z, mv.x].figure_name != "empty")
                        {   // добавляем ели цвет не наш
                            P_Moves_LeftUp.Add(mv);
                 //           Debug.Log(mv.z);
                 //           Debug.Log(mv.x);
                 //           Debug.Log("bishop");
                            break;
                        }
                    }
                }

                if (Can_add)
                {
                    if (scriptToAccess.board[mv.z, mv.x].colors_of_figure != myColor)
                    {
                        //     Debug.Log(mv.z);
                        //    Debug.Log(mv.x);
                        //     Debug.Log("bishop");
                        P_Moves_LeftUp.Add(mv);
                    }
                }
            }
        }

        z = for_z;
        x = for_x;

        Can_add = true;

        for (int i = 0; i < P_Moves_LeftUp.Count; i++)
        {
            All_moves.Add(P_Moves_LeftUp[i]);
        }

        z = for_z;
        x = for_x;

        for (int i = 0; i < P_Moves_LeftDown.Count; i++)
        {
            All_moves.Add(P_Moves_LeftDown[i]);
        }

        z = for_z;
        x = for_x;

        for (int i = 0; i < P_Moves_RightDown.Count; i++)
        {
            All_moves.Add(P_Moves_RightDown[i]);
        }

        z = for_z;
        x = for_x;

        for (int i = 0; i < P_Moves_RightUp.Count; i++)
        {
            All_moves.Add(P_Moves_RightUp[i]);
        }

        z = for_z;
        x = for_x;


        for (int i = 0; i < All_moves.Count; i++)
        {
            All_moves[i].name = "bishop";
            All_moves[i].started_z = for_z;
            All_moves[i].started_x = for_x;

        }

    }
}
