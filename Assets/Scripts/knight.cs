using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Сделано студентом Группы П-304 Терентьевым Дмитрием
/// <summary>
/// Данный класс отвечает за одну из фигур - knight
/// </summary>
public class knight : figure
{   //конь

    public string name = "knight";
    public bool ischeck = false;

    public List<move> P_Moves = new List<move>();   // возможные шаги фигуры 
    public GameObject Core_object;

    /// <summary>
    /// Вычисляет возможные ходы для данного класса
    /// </summary>
    /// <param name="z"> начальная координата по z</param>
    /// <param name="x"> начальная координата по x</param>
    public void PossibleMoves(int z, int x) //   28 возможных ходов
    {

        Core_object = GameObject.Find("Core");
        Core scriptToAccess = Core_object.GetComponent<Core>();

        int myColor = 0;

        if (scriptToAccess.State == 1)
        {

            myColor = 1;
        }
        else
        {
            myColor = 0;
        }

        int for_z, for_x;
        for_z = z;
        for_x = x;

        move mv = new move();
        mv.x = x - 2;
        mv.z = z + 1;
        if (mv.x >= 0 & mv.x < 8 & mv.z >= 0 & mv.z < 8)
        {   // строчка для ограничения хода в границах 8x8 
            if (scriptToAccess.board[mv.z, mv.x].colors_of_figure != myColor || scriptToAccess.board[mv.z, mv.x].figure_name == "empty")
            {
                P_Moves.Add(mv);


              //  Debug.Log(mv.x);
              //  Debug.Log(mv.z);
            }
        }
        z = for_z;
        x = for_x;

        move mv1 = new move();
        mv1.x = x - 1;
        mv1.z = z + 2;
        if (mv1.x >= 0 & mv1.x < 8 & mv1.z >= 0 & mv1.z < 8)
        {   // строчка для ограничения хода в границах 8x8 
            if (scriptToAccess.board[mv1.z, mv1.x].colors_of_figure != myColor || scriptToAccess.board[mv1.z, mv1.x].figure_name == "empty")
            {
                P_Moves.Add(mv1);


             //   Debug.Log(mv1.x);
              //  Debug.Log(mv1.z);
            }
        }
        z = for_z;
        x = for_x;

        move mv2 = new move();
        mv2.x = x + 1;
        mv2.z = z + 2;
        if (mv2.x >= 0 & mv2.x < 8 & mv2.z >= 0 & mv2.z < 8)
        {   // строчка для ограничения хода в границах 8x8 
            if (scriptToAccess.board[mv2.z, mv2.x].colors_of_figure != myColor || scriptToAccess.board[mv2.z, mv2.x].figure_name == "empty")
            {
                P_Moves.Add(mv2);


             //   Debug.Log(mv2.x);
             //   Debug.Log(mv2.z);
            }
        }
        z = for_z;
        x = for_x;

        move mv3 = new move();
        mv3.x = x + 2;
        mv3.z = z + 1;
        if (mv3.x >= 0 & mv3.x < 8 & mv3.z >= 0 & mv3.z < 8)
        {  // строчка для ограничения хода в границах 8x8 
            if (scriptToAccess.board[mv3.z, mv3.x].colors_of_figure != myColor || scriptToAccess.board[mv3.z, mv3.x].figure_name == "empty")
            {
                P_Moves.Add(mv3);


              //  Debug.Log(mv3.x);
              //  Debug.Log(mv3.z);
            }
        }
        z = for_z;
        x = for_x;

        move mv4 = new move();
        mv4.x = x + 2;
        mv4.z = z - 1;
        if (mv4.x >= 0 & mv4.x < 8 & mv4.z >= 0 & mv4.z < 8)
        {   // строчка для ограничения хода в границах 8x8

            if (scriptToAccess.board[mv4.z, mv4.x].colors_of_figure != myColor || scriptToAccess.board[mv4.z, mv4.x].figure_name == "empty")
            {
                P_Moves.Add(mv4);


              //  Debug.Log(mv4.x);
             //   Debug.Log(mv4.z);
            }
        }


        z = for_z;
        x = for_x;

        move mv5 = new move();
        mv5.x = x + 1;
        mv5.z = z - 2;
        if (mv5.x >= 0 & mv5.x < 8 & mv5.z >= 0 & mv5.z < 8)
        {   // строчка для ограничения хода в границах 8x8 
            if (scriptToAccess.board[mv5.z, mv5.x].colors_of_figure != myColor || scriptToAccess.board[mv5.z, mv5.x].figure_name == "empty")
            {
                P_Moves.Add(mv5);


                //Debug.Log(mv5.x);
               // Debug.Log(mv5.z);
            }
        }
        z = for_z;
        x = for_x;

        move mv6 = new move();
        mv6.x = x - 1;
        mv6.z = z - 2;
        if (mv6.x >= 0 & mv6.x < 8 & mv6.z >= 0 & mv6.z < 8)
        { // строчка для ограничения хода в границах 8x8 
            if (scriptToAccess.board[mv6.z, mv6.x].colors_of_figure != myColor || scriptToAccess.board[mv6.z, mv6.x].figure_name == "empty")
            {
                P_Moves.Add(mv6);


               // Debug.Log(mv6.x);
               // Debug.Log(mv6.z);
            }
        }
        z = for_z;
        x = for_x;

        move mv7 = new move();
        mv7.x = x - 2;
        mv7.z = z - 1;
        if (mv7.x >= 0 & mv7.x < 8 & mv7.z >= 0 & mv7.z < 8)
        {  // строчка для ограничения хода в границах 8x8 
            if (scriptToAccess.board[mv7.z, mv7.x].colors_of_figure != myColor || scriptToAccess.board[mv7.z, mv7.x].figure_name == "empty")
            {
                P_Moves.Add(mv7);

            }
          
        }


        for (int i = 0; i < P_Moves.Count; i++)
        {
            P_Moves[i].name = "knight";
           

            P_Moves[i].started_z = for_z;
            P_Moves[i].started_x = for_x;
         //   Debug.Log(P_Moves[i].started_z);
           // Debug.Log(P_Moves[i].started_x);



        }

    }
    
}