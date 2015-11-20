using UnityEngine;
using System.Collections;

public class king : square
{    //король

    public int x;  // x(строка) 
    public int z; //  z(столбец)
    public int colors_of_figure;   // 0 - white 1- black 
    public bool active = false; // активна ли фигура т.е. выбрана ли она пользователем
    public string name = "king";

    public void SetColorAndPosition(int stroka, int stolbec, int color)
    {
        x = stroka;
        z = stolbec;
        colors_of_figure = colors;

    }
	
}
