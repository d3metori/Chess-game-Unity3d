using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Сделано студентом Группы П-304 Терентьевым Дмитрием

public class AI : MonoBehaviour {

    public GameObject Core_object;


    private int cost_pawn = 100;    // ценность обьектов
    private int cost_knight = 300;
    private int cost_bishop = 300;
    private int cost_rook = 450;
    private int queen = 900;
    private int king = 100000;

    public List<figure> first = new List<figure>();

 public void StartThinking()
 {
     checkForMovement();
 }

 public  void checkForMovement()         // первый просчет всех ходов
    {
        Core scriptToAccess = Core_object.GetComponent<Core>();

        for (int i = 0; i < 7; i++) // строка
        {
            for (int j = 0; j < 7; j++) // столбец
            {
                scriptToAccess.isMoveCanBe(scriptToAccess.board[i, j].figure_name, scriptToAccess.board[i, j].colors_of_figure);

               // first.Add(scriptToAccess.board[i, j]);
            }
        }

        MOVEForAI(6,0,5,0);

    }

 public void MOVEForAI(int z, int x, int second_z, int second_x)
 {
     Core scriptToAccess = Core_object.GetComponent<Core>();

     if (scriptToAccess.State == 1)    // идет нужная логика где мы выбираем потенциально аенный ход и двигаем фигурки
     {
         scriptToAccess.z = z;  // координаты первой активной фигуры для движения
         scriptToAccess.x = x;
         scriptToAccess.second_z = second_z;    // координаты второй активной фигуры для движения
         scriptToAccess.second_x = second_x;

         scriptToAccess.MoveFigure();
         scriptToAccess.State = 0;  // 1 - ход АИ 0 - Ход Игрока
     }
 }



}
