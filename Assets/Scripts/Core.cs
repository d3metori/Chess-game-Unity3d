using UnityEngine;
using System.Collections;

public class Core : MonoBehaviour {

    public int State = 0; // 0,1  0 - ход белых, 1 - ход черных
    public GameObject cell;
    public square [,] board = new square[8,8]; // доска


    void Awake()    // при создании кадра происходит до Start 
    {
        filing_table();
    }

    void filing_table()    // заполняем доску
    {
        square sw = new square();

        for (int x = 0; x < 8; x++) // строка
        {
            for (int z = 0; z < 8; z++) // столбец
            {
               
                sw.FigureCreating(0, x, z, 0, false);  // заполняем доску пустыми клетками
                board[x, z] = sw;
               
            }
        }

        //  Белые фигуры

       sw.FigureCreating(2, 0, 0, 0, false);   // класс фигуры, координаты, цвет , направление 0 (белые к черным) или 1 (черные к белым)
       board[0, 0] = sw;

       sw.FigureCreating(3, 0, 1, 0, false);
       board[0, 1] = sw;

       sw.FigureCreating(4, 0, 2, 0, false);
       board[0, 2] = sw;

       sw.FigureCreating(5, 0, 3, 0, false);
       board[0, 3] = sw;

       sw.FigureCreating(6, 0, 4, 0, false);
       board[0, 4] = sw;

       sw.FigureCreating(4, 0, 5, 0, false);
       board[0, 5] = sw;

       sw.FigureCreating(3, 0, 6, 0, false);
       board[0, 6] = sw;

       sw.FigureCreating(2, 0, 7, 0, false);
       board[0, 7] = sw;

       for (int z = 0; z < 8; z++) // заполняем все столбцы 2ой строки белыми пешками
       {
           sw.FigureCreating(1, 1, z, 0, false);  
           board[2, z] = sw;
       }

       // Черные фигуры

       sw.FigureCreating(2, 7, 0, 1, true);   // класс фигуры, координаты, цвет , направление 0 (белые к черным) или 1 (черные к белым)
       board[7, 0] = sw;

       sw.FigureCreating(3, 7, 1, 1, true);
       board[7, 1] = sw;

       sw.FigureCreating(4, 7, 2, 1, true);
       board[7, 2] = sw;

       sw.FigureCreating(5, 7, 3, 1, true);
       board[7, 3] = sw;

       sw.FigureCreating(6, 7, 4, 1, true);
       board[7, 4] = sw;

       sw.FigureCreating(4, 7, 5, 1, true);
       board[7, 5] = sw;

       sw.FigureCreating(3, 7, 6, 1, true);
       board[7, 6] = sw;

       sw.FigureCreating(2, 7, 7, 1, true);
       board[7, 7] = sw;
        

       for (int z = 0; z < 8; z++) // заполняем все столбцы 7ой строки черными пешками
       {
           sw.FigureCreating(1, 6, z, 1, true);
           board[1, z] = sw;

       }
    }

    void Start()
    {

        board[0, 0].SelectFigure(2, 0, 0, 0);
        Debug.Log(board[0, 0].white_rooks[0].active);
        

    }

    void Update()
    {
        

    }



}
