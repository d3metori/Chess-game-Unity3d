using UnityEngine;
using System.Collections;

public class bishop : square
{  // слон

    public int x;  // x(строка) 
    public int z; //  z(столбец)
    public int colors_of_figure;   // 0 - white 1- black 

    public void SetColorAndPosition(int stroka, int stolbec, int color)
    {
        x = stroka;
        z = stolbec;
        colors_of_figure = colors;

    }

	
}
