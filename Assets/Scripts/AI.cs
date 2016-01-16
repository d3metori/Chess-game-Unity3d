using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Сделано студентом Группы П-304 Терентьевым Дмитрием

public class AI : MonoBehaviour {

    public GameObject Core_object;


    public List<move> All_mv = new List<move>(); // доступные ходы АИ
    public List<move> P_All_mv = new List<move>(); // доступные ходы игроку
    public List<move> Atck_mv = new List<move>(); // массив с теми когоможно скушать
    public List<move> Move_mv = new List<move>(); // массив с теми когоможно скушать

    int cost_of_eaten = 0;
    int from_x;
    int from_z;
    int to_x;
    int to_z;


    public int[,] board = new int[8, 8]; // доска с оценкой для клеток

    private int cost_pawn = 10;    // ценность фигур
    private int cost_knight = 30;
    private int cost_bishop = 30;
    private int cost_rook = 45;
    private int queen = 95;
    private int king = 1000000;

    private int cost_m_pawn = 20;    // ценность для продвижения фигур
    private int cost_m_knight = 30;
    private int cost_m_bishop = 15;
    private int cost_m_rook = 15;
    private int m_queen = 15;
    private int m_king = 5;


    int cost_f; // ценность фигрки
        int started_cost_f;
    int cost_m; // ценность хода
        int started_cost_m; 

    bool danger = false; // в опасности ли король?

    public List<figure> first = new List<figure>();

 public void StartThinking()
 {
     checkForMovement();    // собираем массив ходов
     set_weight_of_board();
     calculate();

 }

 public void calculate()
 {
     danger = false;
     cost_of_eaten = 0;

     Core scriptToAccess = Core_object.GetComponent<Core>();
     
     for (int j = 0; j < P_All_mv.Count; j++)
     {
         if (scriptToAccess.board[P_All_mv[j].z, P_All_mv[j].x].figure_name == "king" & scriptToAccess.board[P_All_mv[j].z, P_All_mv[j].x].colors_of_figure == 1)
         {


             Debug.Log("KingInDanger!!");
             Debug.Log(P_All_mv[j].z);
             Debug.Log(P_All_mv[j].x);
             Debug.Log(P_All_mv[j].started_z);
             Debug.Log(P_All_mv[j].started_x);

             danger = true;

         }
     }

     for (int i = 0; i < All_mv.Count; i++)
     {
         if (danger)
         {
             
         }
         else
         {
             if (scriptToAccess.board[All_mv[i].z, All_mv[i].x].colors_of_figure == 0)
             {
                 Atck_mv.Add(All_mv[i]);    // добавляем того кого можем схрумкать в массив
                 Debug.Log("added_to_attack");
             }
             else
             {
                 Move_mv.Add(All_mv[i]);    //  ход
                 Debug.Log("added_to_move");
             }
         }
     }

     if (Atck_mv.Count > 0) // смотрим кого мы можем скушать
     {
         for (int i = 0; i < Atck_mv.Count; i++)
         {
             if (scriptToAccess.board[Atck_mv[i].z, Atck_mv[i].x].figure_name == "pawn")
             {
                 if (cost_of_eaten < cost_pawn)
                 {
                     cost_of_eaten = cost_pawn;
                     from_x = Atck_mv[i].started_x;
                     from_z = Atck_mv[i].started_z;

                     to_x = Atck_mv[i].x;
                     to_z = Atck_mv[i].z;
                 }
             }

             if (scriptToAccess.board[Atck_mv[i].z, Atck_mv[i].x].figure_name == "knight")
             {
                 if (cost_of_eaten < cost_knight)
                 {
                     cost_of_eaten = cost_knight;
                     from_x = Atck_mv[i].started_x;
                     from_z = Atck_mv[i].started_z;

                     to_x = Atck_mv[i].x;
                     to_z = Atck_mv[i].z;
                 }
             }

             if (scriptToAccess.board[Atck_mv[i].z, Atck_mv[i].x].figure_name == "pawn")
             {
                 if (cost_of_eaten < cost_pawn)
                 {
                     cost_of_eaten = cost_pawn;
                     from_x = Atck_mv[i].started_x;
                     from_z = Atck_mv[i].started_z;

                     to_x = Atck_mv[i].x;
                     to_z = Atck_mv[i].z;
                 }
             }

             if (scriptToAccess.board[Atck_mv[i].z, Atck_mv[i].x].figure_name == "king")
             {
                 
                     from_x = Atck_mv[i].started_x;
                     from_z = Atck_mv[i].started_z;

                     to_x = Atck_mv[i].x;
                     to_z = Atck_mv[i].z;
                 
             }

             if (scriptToAccess.board[Atck_mv[i].z, Atck_mv[i].x].figure_name == "bishop")
             {
                 if (cost_of_eaten < cost_bishop)
                 {
                     cost_of_eaten = cost_bishop;
                     from_x = Atck_mv[i].started_x;
                     from_z = Atck_mv[i].started_z;

                     to_x = Atck_mv[i].x;
                     to_z = Atck_mv[i].z;
                 }
             }

             if (scriptToAccess.board[Atck_mv[i].z, Atck_mv[i].x].figure_name == "queen")
             {
                 if (cost_of_eaten < queen)
                 {
                     cost_of_eaten = queen;
                     from_x = Atck_mv[i].started_x;
                     from_z = Atck_mv[i].started_z;

                     to_x = Atck_mv[i].x;
                     to_z = Atck_mv[i].z;
                 }
             }

             if (scriptToAccess.board[Atck_mv[i].z, Atck_mv[i].x].figure_name == "rook")
             {
                 if (cost_of_eaten < cost_rook)
                 {
                     cost_of_eaten = cost_rook;
                     from_x = Atck_mv[i].started_x;
                     from_z = Atck_mv[i].started_z;

                     to_x = Atck_mv[i].x;
                     to_z = Atck_mv[i].z;
                 }
             }

         //    MOVEForAI(from_z, from_x, to_z, to_x); // идем кушать

         }

     }
     else  // иначе идем своей дорогой :)
     {

         for (int i = 0; i < All_mv.Count; i++)
         {
             started_cost_f = 0;
             started_cost_m = 0;

             if (scriptToAccess.board[Atck_mv[i].started_z, Atck_mv[i].started_x].figure_name == "pawn")
             {
                 started_cost_m = cost_m_pawn + board[Atck_mv[i].z, Atck_mv[i].x];
                 Debug.Log("cost");
                 Debug.Log(started_cost_m);

             }

             if (scriptToAccess.board[Atck_mv[i].started_z, Atck_mv[i].started_x].figure_name == "knight")
             {
                 started_cost_m = cost_m_knight + board[Atck_mv[i].z, Atck_mv[i].x];
                 Debug.Log("cost");
                 Debug.Log(started_cost_m);
             }

             if (scriptToAccess.board[Atck_mv[i].started_z, Atck_mv[i].started_x].figure_name == "king")
             {
                 started_cost_m = m_king + board[Atck_mv[i].z, Atck_mv[i].x];
                 Debug.Log("cost");
                 Debug.Log(started_cost_m);
             }

             if (scriptToAccess.board[Atck_mv[i].started_z, Atck_mv[i].started_x].figure_name == "bishop")
             {
                 started_cost_m = cost_m_bishop + board[Atck_mv[i].z, Atck_mv[i].x];
                 Debug.Log("cost");
                 Debug.Log(started_cost_m);
             }

             if (scriptToAccess.board[Atck_mv[i].started_z, Atck_mv[i].started_x].figure_name == "bishop")
             {
                 started_cost_m = cost_m_bishop + board[Atck_mv[i].z, Atck_mv[i].x];
                 Debug.Log("cost");
                 Debug.Log(started_cost_m);
             }

             if (scriptToAccess.board[Atck_mv[i].started_z, Atck_mv[i].started_x].figure_name == "queen")
             {
                 started_cost_m = m_queen + board[Atck_mv[i].z, Atck_mv[i].x];
                 Debug.Log("cost");
                 Debug.Log(started_cost_m);
             }

             if (scriptToAccess.board[Atck_mv[i].started_z, Atck_mv[i].started_x].figure_name == "rook")
             {
                 started_cost_m = m_queen + board[Atck_mv[i].z, Atck_mv[i].x];
                 Debug.Log("cost");
                 Debug.Log(started_cost_m);
             }
             

             if (cost_m < started_cost_m)
             {
                 cost_m = started_cost_m;
                 from_x = Atck_mv[i].started_x;
                 from_z = Atck_mv[i].started_z;

                 to_x = Atck_mv[i].x;
                 to_z = Atck_mv[i].z;

             }
         }
         Debug.Log("from and to");
         Debug.Log(from_z);
         Debug.Log(from_x);
         Debug.Log(to_z);
         Debug.Log(to_x);

         from_z = 6;
         from_x = 0;
         to_z = 5;
         to_x = 0;

       //  MOVEForAI(from_z, from_x, to_z, to_x);

     }
 }


 public void set_weight_of_board()
 {
      Core scriptToAccess = Core_object.GetComponent<Core>();

      if (scriptToAccess.moves < 5)
      {
          for (int i = 0; i < 7; i++)
          {
              board[7, i] = 10;
              board[6, i] = 10;
              board[5, i] = 20;
              board[4, i] = 30;
              board[3, i] = 40;
              board[2, i] = 30;
              board[1, i] = 20;
              board[0, i] = 10;
          }
      }

      if (scriptToAccess.moves > 5)
      {
          for (int i = 0; i < 7; i++)
          {
              board[7, i] = 10;
              board[6, i] = 10;
              board[5, i] = 20;
              board[4, i] = 20;
              board[3, i] = 30;
              board[2, i] = 40;
              board[1, i] = 50;
              board[0, i] = 60;
          }
      }
      Debug.Log("settled");
 }
 public void checkForMovement()         // собирает все возможные ходы
    {
        Core scriptToAccess = Core_object.GetComponent<Core>();

       for (int i = 0; i < 7; i++) 
        {
            for (int j = 0; j < 7; j++)
            {


                if (scriptToAccess.board[i, j].figure_name == "bishop")
                {
                    if (scriptToAccess.board[i, j].colors_of_figure == 1)
                    {

                        bishop b = new bishop();
                        b.colors_of_figure = 1;
                        b.PossibleMoves(i, j);
                        for (int x = 0; x < b.All_moves.Count; x++)
                        {
                           Debug.Log("bishops");

                            All_mv.Add(b.All_moves[x]);

                        }
                    }
                    else   // иначе мы смотрим ход для игрока
                    {
                        bishop b = new bishop();
                        b.colors_of_figure = 0;
                        b.PossibleMoves(i, j);
                        for (int x = 0; x < b.All_moves.Count; x++)
                        {
                        //    Debug.Log("bishops");

                            P_All_mv.Add(b.All_moves[x]);

                        }
                    }
                }

                if (scriptToAccess.board[i, j].figure_name == "king")
                {
                    if (scriptToAccess.board[i, j].colors_of_figure == 1)
                    {

                        king b = new king();
                        b.colors_of_figure = 1;
                        b.PossibleMoves(i, j);
                        for (int x = 0; x < b.P_Moves.Count; x++)
                        {
                           Debug.Log("king");

                            All_mv.Add(b.P_Moves[x]);

                        }
                    }
                    else   // иначе мы смотрим ход для игрока
                    {
                        king b = new king();
                        b.colors_of_figure = 1;
                        b.PossibleMoves(i, j);
                        for (int x = 0; x < b.P_Moves.Count; x++)
                        {
                           

                            P_All_mv.Add(b.P_Moves[x]);

                        }
                    }
                }

                if (scriptToAccess.board[i, j].figure_name == "knight")
                {
                    if (scriptToAccess.board[i, j].colors_of_figure == 1)
                    {

                        knight b = new knight();
                        b.colors_of_figure = 1;
                        b.PossibleMoves(i, j);
                        for (int x = 0; x < b.P_Moves.Count; x++)
                        {
                            Debug.Log("knight");

                            All_mv.Add(b.P_Moves[x]);

                        }
                    }
                    else   // иначе мы смотрим ход для игрока
                    {
                        knight b = new knight();
                        b.colors_of_figure = 1;
                        b.PossibleMoves(i, j);
                        for (int x = 0; x < b.P_Moves.Count; x++)
                        {
                      //      Debug.Log("knight");

                            P_All_mv.Add(b.P_Moves[x]);

                        }
                    }
                }

                if (scriptToAccess.board[6, 0].figure_name == "pawn")
                {
                    if (scriptToAccess.board[i, j].colors_of_figure == 1)
                    {

                        pawn b = new pawn();
                        b.colors_of_figure = 1;
                        b.PossibleMoves(6, 0);
                        for (int x = 0; x < b.P_Moves.Count; x++)
                        {
                            Debug.Log("pawn");
                            All_mv.Add(b.P_Moves[x]);

                        }

                        for (int x = 0; x < b.Attack_Moves.Count; x++)
                        {
                            Debug.Log("pawn");
                            All_mv.Add(b.Attack_Moves[x]);

                        }

                    }
                    else
                    {
                        pawn b = new pawn();
                        b.colors_of_figure = 0;
                        b.PossibleMoves(6, 0);
                        for (int x = 0; x < b.P_Moves.Count; x++)
                        {

                            P_All_mv.Add(b.P_Moves[x]);


                        }

                        for (int x = 0; x < b.Attack_Moves.Count; x++)
                        {

                            P_All_mv.Add(b.Attack_Moves[x]);

                        }


                    }
                    
                }

                if (scriptToAccess.board[i, j].figure_name == "queen")
                {
                    if (scriptToAccess.board[i, j].colors_of_figure == 1)
                    {

                        queen b = new queen();
                        b.colors_of_figure = 1;
                        b.PossibleMoves(i, j);
                        for (int x = 0; x < b.All_moves.Count; x++)
                        {
                            Debug.Log("queen");

                            All_mv.Add(b.All_moves[x]);

                        }
                    }
                    else   // иначе мы смотрим ход для игрока
                    {
                        queen b = new queen();
                        b.colors_of_figure = 0;
                        b.PossibleMoves(i, j);
                        for (int x = 0; x < b.All_moves.Count; x++)
                        {
                     //       Debug.Log("queen");

                            P_All_mv.Add(b.All_moves[x]);

                        }
                    }
                }
                

                if (scriptToAccess.board[i, j].figure_name == "rook")
                {
                    if (scriptToAccess.board[i, j].colors_of_figure == 1)
                    {

                        rook b = new rook();
                        b.colors_of_figure = 1;
                        b.PossibleMoves(i, j);
                        for (int x = 0; x < b.All_moves.Count; x++)
                        {
                            Debug.Log("rook");

                            All_mv.Add(b.All_moves[x]);

                        }
                    }
                    else   // иначе мы смотрим ход для игрока
                    {
                        rook b = new rook();
                        b.colors_of_figure = 1;
                        b.PossibleMoves(i, j);
                        for (int x = 0; x < b.All_moves.Count; x++)
                        {
                     //       Debug.Log("rook");

                            P_All_mv.Add(b.All_moves[x]);

                        }
                    }
                }
            }
       }
    }

 public void MOVEForAI(int z, int x, int second_z, int second_x)    // z x координаты первой фигуры, s_z s_x координаты 2ой фигуры
 {

     Debug.Log("MoveForAI");
     Debug.Log(z);
     Debug.Log(x);
     Debug.Log(second_z);
     Debug.Log(second_x);
     Core scriptToAccess = Core_object.GetComponent<Core>();

     if (scriptToAccess.State == 1)    // идет нужная логика где мы выбираем потенциально аенный ход и двигаем фигурки
     {
         scriptToAccess.z = z;  // координаты первой активной фигуры для движения
         scriptToAccess.x = x;
         scriptToAccess.second_z = second_z;    // координаты второй активной фигуры для движения
         scriptToAccess.second_x = second_x;
         if (scriptToAccess.board[second_z, second_x].colors_of_figure == 0)
         {
             scriptToAccess.AttackFigure();
         }
         else
         {
             scriptToAccess.MoveFigure();
         }
         
         scriptToAccess.State = 0;  // 1 - ход АИ 0 - Ход Игрока

     }
 }



}
