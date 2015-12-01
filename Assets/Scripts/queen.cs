using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class queen : figure
{   // королева

    
    public string name = "queen";
    public List<move> P_Moves_LeftUp = new List<move>();    // массивы для направлений
    public List<move> P_Moves_RightUp = new List<move>();
    public List<move> P_Moves_LeftDown = new List<move>();
    public List<move> P_Moves_RightDown = new List<move>();
    public List<move> P_Moves_Up = new List<move>();   
    public List<move> P_Moves_Down = new List<move>();
    public List<move> P_Moves_Left = new List<move>();
    public List<move> P_Moves_Right = new List<move>();


    public void PossibleMoves(int z, int x) //   28 возможных ходов
    {
      

        for (int i = 1; i < 8; i++ )    // Вверх
        {
            move mv = new move();
            mv.x = x;
            mv.z = z + i;
            if (x >= 0 & x < 8 & z >= 0 & z < 8)    // строчка для ограничения хода в границах 8x8 
            {  
                P_Moves_Up.Add(mv);
            }
        }

        for (int i = 1; i < 8; i++)    // Вниз
        {
            move mv = new move();   
            mv.x = x;
            mv.z = z - i;
            if (x >= 0 & x < 8 & z >= 0 & z < 8)    // строчка для ограничения хода в границах 8x8 
            {
                P_Moves_Down.Add(mv);
            }
        }

        for (int i = 1; i < 8; i++)    // Влево
        {
            move mv = new move();  
            mv.x = x - i;
            mv.z = z;
            if (x >= 0 & x < 8 & z >= 0 & z < 8)    // строчка для ограничения хода в границах 8x8 
            {
                P_Moves_Left.Add(mv);
            }
        }

        for (int i = 1; i < 8; i++)    // Вправо
        {
            move mv = new move();
            mv.x = x + i;
            mv.z = z;
            if (x >= 0 & x < 8 & z >= 0 & z < 8)    // строчка для ограничения хода в границах 8x8 
            {
                P_Moves_Left.Add(mv);
            }
        }


        for (int i = 1; i < 8; i++)    // Вправо+Вверх
        {
            move mv = new move();
            mv.x = x + i;
            mv.z = z + i;
            if (x >= 0 & x < 8 & z >= 0 & z < 8)    // строчка для ограничения хода в границах 8x8 
            {
                P_Moves_RightUp.Add(mv);
            }
        }

        for (int i = 1; i < 8; i++)    // Вправо+Вниз
        {
            move mv = new move();
            mv.x = x + i;
            mv.z = z - i;
            if (x >= 0 & x < 8 & z >= 0 & z < 8)    // строчка для ограничения хода в границах 8x8 
            {
                P_Moves_RightDown.Add(mv);
            }
        }

        for (int i = 1; i < 8; i++)    // Влево+Вниз
        {
            move mv = new move();
            mv.x = x - i;
            mv.z = z - i;
            if (x >= 0 & x < 8 & z >= 0 & z < 8)    // строчка для ограничения хода в границах 8x8 
            {
                P_Moves_LeftDown.Add(mv);
            }
        }

        for (int i = 1; i < 8; i++)    // Влево+Вверх
        {
            move mv = new move();
            mv.x = x - i;
            mv.z = z + i;
            if (x >= 0 & x < 8 & z >= 0 & z < 8)    // строчка для ограничения хода в границах 8x8 
            {
                P_Moves_LeftUp.Add(mv);
            }
        }

          

    }
 
}
