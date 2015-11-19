using UnityEngine;
using System.Collections;

public class square  {

        public int[,] position;  // позиция данной клетки где x(строка) z(столбец)
        public int colors;   // 0 - white 1- black цвет
        public bool empty = false;

        public pawn[] pawns = new pawn[10]; // массив из пешек
        public rook[] rooks = new rook[10]; // массив из ладей
        public queen[] queens = new queen[10]; // массив из королев
        public bishop[] bishops = new bishop[10]; // массив из слонов
        public knight[] knights = new knight[10]; // массив из коней

        public string name; 

        public void Unit(string a_name, int a_color) 
        { 
            name = a_name; 
            colors = a_color; 
        }

        public void FigureCreating(int number_of_figure, int x, int z, int a_color, bool dir)
        {

            switch (number_of_figure)   // думаю стоит передавать цвет и позицию 
            {
                case 0: // клетка пуста
                    empty = true;
                    break;

                case 1: // в клетке пешка (pawn)

                    pawn pn = new pawn();
                    pn.SetColorAndPosition(x, z, a_color, dir);

                    break;

                case 2: // в клетке ладья (rook)

                    rook rk = new rook();
                    rk.SetColorAndPosition(x, z, a_color);

                    break;

                case 3: // в клетке конь (knight)

                    knight kg = new knight();
                    kg.SetColorAndPosition(x, z, a_color);

                    break;

                case 4: // в клетке слон (bishop)

                    bishop bs = new bishop();
                    bs.SetColorAndPosition(x, z, a_color);

                    break;

                case 5: // в клетке королева (queen)

                    queen qn = new queen();
                    qn.SetColorAndPosition(x, z, a_color);

                    break;


                case 6: // в клетке король (king)

                    king kin = new king();
                    kin.SetColorAndPosition(x, z, a_color);

                    break;

            }
                    
            
        }
    
       
    }
