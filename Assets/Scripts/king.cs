using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Сделано студентом Группы П-304 Терентьевым Дмитрием

public class king : figure 
{    //король
    public GameObject Core_object;

    public bool isCheck = false;
    public bool isMate = false;
    public string name = "king";

    public List<move> P_Moves = new List<move>();   // возможные шаги фигуры 
    public List<move> P_Moves_r = new List<move>();   // ходы для рокировки (всего 2 вида - длинная/короткая)




    public void PossibleMoves(int z, int x) // 8 возможных ходов + рокировка(стоит дописать)
    {
        int for_z, for_x;
        for_z = z;
        for_x = x;

        Core_object = GameObject.Find("Core");
        Core scriptToAccess = Core_object.GetComponent<Core>(); //для проверки налиия пустых клеток для рокировки
        int myColor = 0;
        if (scriptToAccess.State == 1)
        {
            myColor = 1;
        }
        else
        {
            myColor = 0;
        }


        if(scriptToAccess.board[0,4].colors_of_figure == 0){    // рокировка для белого короля
            if (z == 0 & x == 4)
            {
                if (scriptToAccess.board[0, 2].figure_name == "empty" & scriptToAccess.board[0, 3].figure_name == "empty" & scriptToAccess.board[0, 0].figure_name == "rook")//long
                {
                    z = for_z;
                    x = for_x;


                    move lv = new move();
                    lv.x = x - 2;
                    lv.z = z;
                    P_Moves_r.Add(lv);
                }

                z = for_z;
                x = for_x;

                if (scriptToAccess.board[0, 5].figure_name == "empty" & scriptToAccess.board[0, 6].figure_name == "empty" & scriptToAccess.board[0, 7].figure_name == "rook")//short
                {
                    move sv = new move();
                    sv.x = x + 2;
                    sv.z = z;
                    P_Moves_r.Add(sv);
                }

                z = for_z;
                x = for_x;
            }
        }

        if (scriptToAccess.board[0, 4].colors_of_figure == 1)   // рокировка для чернрго короля
        {
            if (z == 7 & x == 4)
            {
                if (scriptToAccess.board[7, 2].figure_name == "empty" & scriptToAccess.board[7, 3].figure_name == "empty")//long
                {
                    z = for_z;
                    x = for_x;

                    move lv = new move();
                    lv.x = x - 2;
                    lv.z = z;
                    P_Moves_r.Add(lv);
                }

                if (scriptToAccess.board[7, 5].figure_name == "empty" & scriptToAccess.board[7, 6].figure_name == "empty")//short
                {
                    z = for_z;
                    x = for_x;

                    move sv = new move();
                    sv.x = x + 2;
                    sv.z = z;
                    P_Moves_r.Add(sv);
                }
            }
        }

        z = for_z;
        x = for_x;

        move mv = new move();
        mv.x = x + 1;       // право-верх направление
        mv.z = z + 1;
        if (mv.x >= 0 & mv.x < 8 & mv.z >= 0 & mv.z < 8)   // строчка для ограничения хода в границах 8x8 
        {
            if (scriptToAccess.board[mv.z, mv.x].colors_of_figure != myColor || scriptToAccess.board[mv.z, mv.x].figure_name == "empty")
            {
                P_Moves.Add(mv);
              //  Debug.Log(myColor);
              //  Debug.Log(scriptToAccess.board[mv.z, mv.x].colors_of_figure);
                Debug.Log(mv.z);
                Debug.Log(mv.x);
                Debug.Log("king");
            }

        }

        z = for_z;
        x = for_x;


        move mv1 = new move();
        mv1.x = x + 1;       // право направление
        mv1.z = z;
        if (mv1.x >= 0 & mv1.x < 8 & mv1.z >= 0 & mv1.z < 8)   // строчка для ограничения хода в границах 8x8 
        {
            if (scriptToAccess.board[mv1.z, mv1.x].colors_of_figure != myColor || scriptToAccess.board[mv1.z, mv1.x].figure_name == "empty")
            {
                P_Moves.Add(mv1);
                Debug.Log("road_to");
                Debug.Log(scriptToAccess.board[mv1.z, mv1.x].colors_of_figure);
                Debug.Log(scriptToAccess.board[mv1.z, mv1.x].figure_name);
                Debug.Log("from");
                Debug.Log(scriptToAccess.board[for_z, for_x].colors_of_figure);
                Debug.Log(scriptToAccess.board[for_z, for_x].figure_name);
                Debug.Log("myolor");


                Debug.Log(mv1.z);
                Debug.Log(mv1.x);
                Debug.Log("king");
            }

        }

        z = for_z;
        x = for_x;

        move mv2 = new move();
        mv2.x = x + 1;       // право-вниз направление
        mv2.z = z - 1;
        if (mv2.x >= 0 & mv2.x < 8 & mv2.z >= 0 & mv2.z < 8)   // строчка для ограничения хода в границах 8x8 
        {
            if (scriptToAccess.board[mv2.z, mv2.x].colors_of_figure != myColor || scriptToAccess.board[mv2.z, mv2.x].figure_name == "empty")
            {
                P_Moves.Add(mv2);
                Debug.Log(mv2.z);
                Debug.Log(mv2.x);
                Debug.Log("king");
            }

        }

        z = for_z;
        x = for_x;

        move mv3 = new move();
        mv3.x = x;       // вниз направление
        mv3.z = z - 1;
        if (mv3.x >= 0 & mv3.x < 8 & mv3.z >= 0 & mv3.z < 8)   // строчка для ограничения хода в границах 8x8 
        {
            if (scriptToAccess.board[mv3.z, mv3.x].colors_of_figure != myColor || scriptToAccess.board[mv3.z, mv3.x].figure_name == "empty")
            {
                P_Moves.Add(mv3);
               Debug.Log(mv3.z);
                Debug.Log(mv3.x);
                Debug.Log("king");
            }

        }

        z = for_z;
        x = for_x;

        move mv4 = new move();
        mv4.x = x - 1;       // влево-вниз направление
        mv4.z = z - 1;
        if (mv4.x >= 0 & mv4.x < 8 & mv4.z >= 0 & mv4.z < 8)   // строчка для ограничения хода в границах 8x8 
        {
            if (scriptToAccess.board[mv4.z, mv4.x].colors_of_figure != myColor || scriptToAccess.board[mv4.z, mv4.x].figure_name == "empty")
            {
                P_Moves.Add(mv4);
                Debug.Log(mv4.z);
                Debug.Log(mv4.x);
                Debug.Log("king");
            }
        }

        z = for_z;
        x = for_x;

        move mv5 = new move();
        mv5.x = x - 1;       // влево направление
        mv5.z = z;
        if (mv5.x >= 0 & mv5.x < 8 & mv5.z >= 0 & mv5.z < 8)   // строчка для ограничения хода в границах 8x8 
        {
            if (scriptToAccess.board[mv5.z, mv5.x].colors_of_figure != myColor || scriptToAccess.board[mv5.z, mv5.x].figure_name == "empty")
            {
                P_Moves.Add(mv5);
                Debug.Log(mv5.z);
                Debug.Log(mv5.x);
                Debug.Log("king");
            }

        }

        z = for_z;
        x = for_x;

        move mv6 = new move();
        mv6.x = x - 1;       // влево-вверх направление
        mv6.z = z + 1;
        if (mv6.x >= 0 & mv6.x < 8 & mv6.z >= 0 & mv6.z < 8)   // строчка для ограничения хода в границах 8x8 
        {
            if (scriptToAccess.board[mv6.z, mv6.x].colors_of_figure != myColor || scriptToAccess.board[mv6.z, mv6.x].figure_name == "empty")
            {
                P_Moves.Add(mv6);
                Debug.Log(mv6.z);
                Debug.Log(mv6.x);
                Debug.Log("king");
            }

        }

        z = for_z;
        x = for_x;

        move mv7 = new move();
        mv7.x = x;       // вверх направление
        mv7.z = z + 1;
        if (mv7.x >= 0 & mv7.x < 8 & mv7.z >= 0 & mv7.z < 8)   // строчка для ограничения хода в границах 8x8 
        {
            if (scriptToAccess.board[mv7.z, mv7.x].colors_of_figure != myColor || scriptToAccess.board[mv7.z, mv7.x].figure_name == "empty")
            {
                Debug.Log("up");
                Debug.Log(scriptToAccess.board[mv7.z, mv7.x].colors_of_figure);
                Debug.Log(myColor);

                P_Moves.Add(mv7);
               Debug.Log(mv7.z);
                Debug.Log(mv7.x);
                Debug.Log("king");
            }

        }




        for (int i = 0; i < P_Moves.Count; i++)
        {
            P_Moves[i].name = "king";
            Debug.Log(P_Moves[i].z);
            Debug.Log(P_Moves[i].x);
            P_Moves[i].started_z = for_z;
            P_Moves[i].started_x = for_x;
        }

        for (int i = 0; i < P_Moves_r.Count; i++)
        {
            P_Moves_r[i].name = "king";
            Debug.Log(P_Moves[i].z);
            Debug.Log(P_Moves[i].x);
            P_Moves_r[i].started_z = for_z;
            P_Moves_r[i].started_x = for_x;
        }

    }
    

}
