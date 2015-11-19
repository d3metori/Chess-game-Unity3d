using UnityEngine;
using System.Collections;

public class pawn : square
{    //пешка

    public int x;  // x(строка) 
    public int z; //  z(столбец)
    public int colors_of_figure;   // 0 - white 1- black 
    public bool direction; // true - white to black else reverse

    public void SetColorAndPosition(int stroka, int stolbec, int color, bool dir)
    {
        x = stroka;
        z = stolbec;
        colors_of_figure = colors;
        direction = dir;

    }
   
    
	
}
