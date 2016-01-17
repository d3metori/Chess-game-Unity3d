using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Сделано студентом Группы П-304 Терентьевым Дмитрием

public class rook : figure
{    //ладья


    public string name = "rook";


    public List<move> All_moves = new List<move>();

    public List<move> P_Moves_Up = new List<move>();    // массивы для направлений
    public List<move> P_Moves_Down = new List<move>();
    public List<move> P_Moves_Left = new List<move>();
    public List<move> P_Moves_Right = new List<move>();


    public GameObject Core_object;
    public bool Can_add = true;

    public void PossibleMoves(int z, int x) //   28 возможных ходов
    {
        Core_object = GameObject.Find("Core");
        Core scriptToAccess = Core_object.GetComponent<Core>();
        int for_z;
        int for_x;

        for_z = z;
        for_x = x;

        int myColor = 0;

     /*  if (scriptToAccess.State == 1)
        {

            myColor = 1;
        }
        else
        {
            myColor = 0;
        }*/

        for (int i = 1; i < 8; i++)    // Вверх
        {
            move mv = new move();
            mv.x = x;
            mv.z = z + i;
            if (mv.x >= 0 & mv.x < 8 & mv.z >= 0 & mv.z < 8)    // строчка для ограничения хода в границах 8x8 
            {


                if (Can_add)
                {
                    if (scriptToAccess.board[mv.z, mv.x].figure_name != "empty")
                    {
                        Can_add = false;
                        if (scriptToAccess.board[scriptToAccess.second_z, scriptToAccess.second_x].colors_of_figure != myColor & scriptToAccess.board[scriptToAccess.second_z, scriptToAccess.second_x].figure_name != "empty")
                        {   // добавляем ели цвет не наш
                            P_Moves_Up.Add(mv);
                        }
                    }
                }

                if (Can_add)
                {

                    P_Moves_Up.Add(mv);
                }
            }
        }

        z = for_z;
        x = for_x;

        Can_add = true;

        for (int i = 1; i < 8; i++)    // Вниз
        {
            move mv = new move();
            mv.x = x;
            mv.z = z - i;
            if (mv.x >= 0 & mv.x < 8 & mv.z >= 0 & mv.z < 8)    // строчка для ограничения хода в границах 8x8 
            {
                if (Can_add)
                {
                    if (scriptToAccess.board[mv.z, mv.x].figure_name != "empty")
                    {
                        Can_add = false;
                        if (scriptToAccess.board[scriptToAccess.second_z, scriptToAccess.second_x].colors_of_figure != myColor & scriptToAccess.board[scriptToAccess.second_z, scriptToAccess.second_x].figure_name != "empty")
                        {   // добавляем ели цвет не наш
                           
                            P_Moves_Down.Add(mv);
                        }
                    }
                }

                if (Can_add)
                {
                    P_Moves_Down.Add(mv);
                }
            }
        }

        z = for_z;
        x = for_x;

        Can_add = true;

        for (int i = 1; i < 8; i++)    // Влево
        {
            move mv = new move();
            mv.x = x - i;
            mv.z = z;
            if (mv.x >= 0 & mv.x < 8 & mv.z >= 0 & mv.z < 8)    // строчка для ограничения хода в границах 8x8 
            {
                if (Can_add)
                {
                    if (scriptToAccess.board[mv.z, mv.x].figure_name != "empty")
                    {
                        Can_add = false;
                        if (scriptToAccess.board[scriptToAccess.second_z, scriptToAccess.second_x].colors_of_figure != myColor & scriptToAccess.board[scriptToAccess.second_z, scriptToAccess.second_x].figure_name != "empty")
                        {   // добавляем ели цвет не наш
                            P_Moves_Left.Add(mv);
                        }
                    }
                }

                if (Can_add)
                {
                    P_Moves_Left.Add(mv);
                }
            }
        }

        z = for_z;
        x = for_x;

        Can_add = true;

        for (int i = 1; i < 8; i++)    // Вправо
        {
            move mv = new move();
            mv.x = x + i;
            mv.z = z;
            if (mv.x >= 0 & mv.x < 8 & mv.z >= 0 & mv.z < 8)    // строчка для ограничения хода в границах 8x8 
            {
                if (Can_add)
                {
                    if (scriptToAccess.board[mv.z, mv.x].figure_name != "empty")
                    {
                        Can_add = false;
                        if (scriptToAccess.board[scriptToAccess.second_z, scriptToAccess.second_x].colors_of_figure != myColor & scriptToAccess.board[scriptToAccess.second_z, scriptToAccess.second_x].figure_name != "empty")
                        {   // добавляем ели цвет не наш
                            P_Moves_Right.Add(mv);
                        }
                    }
                }

                if (Can_add)
                {
                    P_Moves_Right.Add(mv);
                }
            }
        }

        z = for_z;
        x = for_x;

        Can_add = true;

        for (int i = 0; i < P_Moves_Up.Count; i++)
        {
            All_moves.Add(P_Moves_Up[i]);
        }
        for (int i = 0; i < P_Moves_Down.Count; i++)
        {
            All_moves.Add(P_Moves_Down[i]);
        }
        for (int i = 0; i < P_Moves_Left.Count; i++)
        {
            All_moves.Add(P_Moves_Left[i]);
        }
        for (int i = 0; i < P_Moves_Right.Count; i++)
        {
            All_moves.Add(P_Moves_Right[i]);
        }


        for (int i = 0; i < All_moves.Count; i++)
        {
            All_moves[i].started_x = for_x;
            All_moves[i].started_z = for_z;
            Debug.Log("***********");
            Debug.Log(All_moves[i].started_z);
            Debug.Log(All_moves[i].started_x);
            
            Debug.Log("***********");
        }

    }

}