using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class pawn : figure
{    //пешка

    public bool direction; // true - white to black else reverse
    public string name = "pawn";
   // public bool first_move = true; // если первый шаг пешки за игру то +1 возможный ход
    public GameObject Core_object;

    public List<move> P_Moves = new List<move>();   // возможные шаги фигуры 
    public List<move> Attack_Moves = new List<move>();   // для специфичной атаки пешек


    public void PossibleMoves(int z, int x) //   28 возможных ходов
    {

        Core_object = GameObject.Find("Core");
        Core scriptToAccess = Core_object.GetComponent<Core>();


        if (scriptToAccess.State == 0)
        {
            move mv = new move();

            mv.x = x;      // для движения
            mv.z = z + 1;
            if (mv.x >= 0 & mv.x < 8 & mv.z >= 0 & mv.z < 8)   // строчка для ограничения хода в границах 8x8 
            {
                if (scriptToAccess.board[mv.z, mv.x].figure_name == "empty")
                {
                    P_Moves.Add(mv);
                }
            }



            move mv1 = new move();

            mv1.x = x + 1;  // для атаки
            mv1.z = z + 1;
            if (mv1.x >= 0 & mv1.x < 8 & mv1.z >= 0 & mv1.z < 8)   // строчка для ограничения хода в границах 8x8 
            {
                if (scriptToAccess.board[scriptToAccess.second_z, scriptToAccess.second_x].colors_of_figure != 0)
                {
                    Attack_Moves.Add(mv1);
                }                 
            }


            move mv2 = new move();

            mv2.x = x - 1;  // для атаки
            mv2.z = z + 1;
            if (mv2.x >= 0 & mv2.x < 8 & mv2.z >= 0 & mv2.z < 8)   // строчка для ограничения хода в границах 8x8 
            {

                if (scriptToAccess.board[scriptToAccess.second_z, scriptToAccess.second_x].colors_of_figure != 0)
                {
                    Attack_Moves.Add(mv2);
                }
            }


            move mv3 = new move();

            if (first_move)
            {
                mv3.x = x;  // для движения
                mv3.z = z + 2;
                if (mv3.x >= 0 & mv3.x < 8 & mv3.z >= 0 & mv3.z < 8)   // строчка для ограничения хода в границах 8x8 
                {
                    if (scriptToAccess.board[mv.z, mv.x].figure_name == "empty")
                    {
                        P_Moves.Add(mv3);
                        Debug.Log("added pawn");
                    }
                }



            }
        }
        else 
        {
            move mv4 = new move();
            mv4.x = x;      // для движения
            mv4.z = z - 1;
            if (mv4.x >= 0 & mv4.x < 8 & mv4.z >= 0 & mv4.z < 8)   // строчка для ограничения хода в границах 8x8 
            {
                if (scriptToAccess.board[mv4.z, mv4.x].figure_name == "empty")
                {
                    P_Moves.Add(mv4);
                    Debug.Log("added pawn");
                }
            }

            move mv5 = new move();

            mv5.x = x + 1;  // для атаки
            mv5.z = z - 1;
            if (mv5.x >= 0 & mv5.x < 8 & mv5.z >= 0 & mv5.z < 8)   // строчка для ограничения хода в границах 8x8 
            {
                if (scriptToAccess.board[z--, x++].colors_of_figure == 0)
                {
                    if (scriptToAccess.board[scriptToAccess.second_z, scriptToAccess.second_x].colors_of_figure != 1)
                    {
                        Attack_Moves.Add(mv5);
                    }
                }
            }

            move mv6 = new move();

            mv6.x = x - 1;  // для атаки
            mv6.z = z - 1;
            if (mv6.x >= 0 & mv6.x < 8 & mv6.z >= 0 & mv6.z < 8)   // строчка для ограничения хода в границах 8x8 
            {
                if (scriptToAccess.board[z--, x--].colors_of_figure == 0)
                {
                    if (scriptToAccess.board[scriptToAccess.second_z, scriptToAccess.second_x].colors_of_figure != 1)
                    {
                        Attack_Moves.Add(mv6);
                    }
                }
            }


            if (first_move)
            {
                move mv7 = new move();

                mv7.x = x;  // для движения
                mv7.z = z - 2;
                if (mv7.x >= 0 & mv7.x < 8 & mv7.z >= 0 & mv7.z < 8)   // строчка для ограничения хода в границах 8x8  
                {
                    P_Moves.Add(mv7);
                    Debug.Log("added pawn");
                }
            }
        }
    }
}
