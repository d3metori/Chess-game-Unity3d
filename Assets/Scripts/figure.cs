using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class figure  {

    // Для белых фигур

    public int x;  // x(строка) 
    public int z; //  z(столбец)
    public int colors_of_figure;   // 0 - white 1- black 
    public bool active = false; // активна ли фигура т.е. выбрана ли она пользователем
    public bool isSecondActive = false;
    public string figure_name = "empty";
    public bool first_move = true;
   

    }
