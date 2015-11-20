using UnityEngine;
using System.Collections;

public class square  {

        public int[,] position;  // позиция данной клетки где x(строка) z(столбец)
        public int colors;   // 0 - white 1- black цвет
        public bool empty = false;

    // Для белых фигур

        public pawn[] white_pawns = new pawn[10]; // массив из пешек    1
        private int white_numb_p = 0;
        public rook[] white_rooks = new rook[10]; // массив из ладей    2
        private int white_numb_r = 0;
        public knight[] white_knights = new knight[10]; // массив из коней  3
        private int white_numb_k = 0;
        public bishop[] white_bishops = new bishop[10]; // массив из слонов 4
        private int white_numb_b = 0;
        public queen[] white_queens = new queen[10]; // массив из королев   5
        private int white_numb_q = 0;
        public king[] white_kings = new king[10]; // массив для короля  6
        private int white_numb_king = 0;

    // Для черных фигур

        public pawn[] black_pawns = new pawn[10]; // массив из пешек    1
        private int black_numb_p = 0;
        public rook[] black_rooks = new rook[10]; // массив из ладей    2
        private int black_numb_r = 0;
        public knight[] black_knights = new knight[10]; // массив из коней  3
        private int black_numb_k = 0;
        public bishop[] black_bishops = new bishop[10]; // массив из слонов 4
        private int black_numb_b = 0;
        public queen[] black_queens = new queen[10]; // массив из королев   5
        private int black_numb_q = 0;
        public king[] black_kings = new king[10]; // массив для короля  6
        private int black_numb_king = 0;

        public void FigureCreating(int number_of_figure, int x, int z, int a_color, bool dir)   // Создание фигуры
        {

            switch (number_of_figure)   
            {
                case 0: // клетка пуста
                    empty = true;
                    break;

                case 1: // в клетке пешка (pawn)

                    empty = false;
                    pawn pn = new pawn();
                    pn.SetColorAndPosition(x, z, a_color, dir);
                    if (a_color == 0) // a_color - белый
                    {
                        white_pawns[white_numb_p] = pn;
                        white_numb_p++;

                    }
                    else // a_color - черный
                    {
                        black_pawns[black_numb_p] = pn;
                        black_numb_p++;
                    }

                    break;

                case 2: // в клетке ладья (rook)

                    empty = false;
                    rook rk = new rook();
                    rk.SetColorAndPosition(x, z, a_color);
                    if (a_color == 0) // a_color - белый
                    {
                        white_rooks[white_numb_r] = rk;
                        white_numb_r++;

                    }
                    else // a_color - черный
                    {
                        black_rooks[black_numb_r] = rk;
                        black_numb_r++;
                    }

                    break;

                case 3: // в клетке конь (knight)

                    empty = false;
                    knight kg = new knight();
                    kg.SetColorAndPosition(x, z, a_color);
                    if (a_color == 0) // a_color - белый
                    {
                        white_knights[white_numb_k] = kg;
                        white_numb_k++;

                    }
                    else // a_color - черный
                    {
                        black_knights[black_numb_k] = kg;
                        black_numb_k++;
                    }

                    break;

                case 4: // в клетке слон (bishop)

                    empty = false;
                    bishop bs = new bishop();
                    bs.SetColorAndPosition(x, z, a_color);
                    if (a_color == 0) // a_color - белый
                    {
                        white_bishops[white_numb_b] = bs;
                        white_numb_b++;

                    }
                    else // a_color - черный
                    {
                        black_bishops[black_numb_b] = bs;
                        black_numb_b++;
                    }

                    break;

                case 5: // в клетке королева (queen)

                    empty = false;
                    queen qn = new queen();
                    qn.SetColorAndPosition(x, z, a_color);
                    if (a_color == 0) // a_color - белый
                    {
                        white_queens[white_numb_q] = qn;
                        white_numb_q++;

                    }
                    else // a_color - черный
                    {
                        black_queens[black_numb_q] = qn;
                        black_numb_q++;
                    }

                    break;


                case 6: // в клетке король (king)

                    empty = false;
                    king kin = new king();
                    kin.SetColorAndPosition(x, z, a_color);
                    if (a_color == 0) // a_color - белый
                    {
                        white_kings[white_numb_king] = kin;
                        white_numb_king++;

                    }
                    else // a_color - черный
                    {
                        black_kings[black_numb_king] = kin;
                        black_numb_king++;
                    }

                    break;

            }
                    
            
        }

        public void SelectFigure(int number_of_figure, int x, int z, int state_of_game)     // Выбор фигуры
        {

            switch (number_of_figure)
            {
                case 0: // клетка пуста
                    Debug.Log("Выбрана пустая клетка");
                    break;

                case 1: // в клетке пешка (pawn)

                    if (state_of_game == 0) // когда ходят белые
                    {
                        for (int i = 0; i < white_numb_p; i++)
                        {

                            if ((white_pawns[i].x == x) & (white_pawns[i].z == z))
                            {
                                white_pawns[i].active = true;
                            }
                        }

                    }else{  // когда ходят черные

                        for (int i = 0; i <black_numb_p; i++)
                        {

                            if ((black_pawns[i].x == x) & (black_pawns[i].z == z))
                            {
                                black_pawns[i].active = true;
                            }
                        }

                    }
                        break;

                case 2: // в клетке ладья (rook)
                        if (state_of_game == 0) // когда ходят белые
                        {
                            for (int i = 0; i < white_numb_r; i++)
                            {

                                if ((white_rooks[i].x == x) & (white_rooks[i].z == z))
                                {
                                    white_rooks[i].active = true;
                                }
                            }

                        }
                        else
                        {  // когда ходят черные

                            for (int i = 0; i < black_numb_r; i++)
                            {

                                if ((black_rooks[i].x == x) & (black_rooks[i].z == z))
                                {
                                    black_rooks[i].active = true;
                                }
                            }

                        }
                    break;

                case 3: // в клетке конь (knight)
                    if (state_of_game == 0) // когда ходят белые
                    {
                        for (int i = 0; i < white_numb_k; i++)
                        {

                            if ((white_knights[i].x == x) & (white_knights[i].z == z))
                            {
                                white_knights[i].active = true;
                            }
                        }

                    }
                    else
                    {  // когда ходят черные

                        for (int i = 0; i < black_numb_k; i++)
                        {

                            if ((black_knights[i].x == x) & (black_knights[i].z == z))
                            {
                                black_knights[i].active = true;
                            }
                        }

                    }

                    break;
                case 4: // в клетке слон (bishop)
                    if (state_of_game == 0) // когда ходят белые
                    {
                        for (int i = 0; i < white_numb_b; i++)
                        {

                            if ((white_bishops[i].x == x) & (white_bishops[i].z == z))
                            {
                                white_bishops[i].active = true;
                            }
                        }

                    }
                    else
                    {  // когда ходят черные

                        for (int i = 0; i < black_numb_b; i++)
                        {

                            if ((black_bishops[i].x == x) & (black_bishops[i].z == z))
                            {
                                black_bishops[i].active = true;
                            }
                        }
                    }
                    break;

                case 5: // в клетке королева (queen)
                    if (state_of_game == 0) // когда ходят белые
                    {
                        for (int i = 0; i < white_numb_q; i++)
                        {

                            if ((white_queens[i].x == x) & (white_queens[i].z == z))
                            {
                                white_queens[i].active = true;
                            }
                        }

                    }
                    else
                    {  // когда ходят черные

                        for (int i = 0; i < black_numb_q; i++)
                        {

                            if ((black_queens[i].x == x) & (black_queens[i].z == z))
                            {
                                black_queens[i].active = true;
                            }
                        }
                    }

                    break;

                case 6: // в клетке король (king)
                    if (state_of_game == 0) // когда ходят белые
                    {
                        for (int i = 0; i < white_numb_king; i++)
                        {

                            if ((white_kings[i].x == x) & (white_kings[i].z == z))
                            {
                                white_kings[i].active = true;
                            }
                        }

                    }
                    else
                    {  // когда ходят черные

                        for (int i = 0; i < black_numb_king; i++)
                        {

                            if ((black_kings[i].x == x) & (black_kings[i].z == z))
                            {
                                black_kings[i].active = true;
                            }
                        }
                    }

                    break;

            }
        }


    }
