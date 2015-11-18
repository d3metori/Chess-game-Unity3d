using UnityEngine;
using System.Collections;

public class figure
{
    public int[] position;  // позиция данной фигуры где [1] - x(строка)   [2] - z(столбец)
    public enum colors { white = 1, black = 2 };    // дабы не считать с нуля
    public colors colors_of_figure;

}
