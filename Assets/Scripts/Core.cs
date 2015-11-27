using UnityEngine;
using System.Collections;

public class Core : MonoBehaviour {

    public int State = 0; // 0,1  0 - ход белых, 1 - ход черных
    public bool  move_updated = false; //для визуального обновления всех фигур
        public bool first_time_updated = false; // вспомогательная переменная для move_updated
    public figure[,] board = new figure[8,8]; // доска
    public figure buffer;   // вспомогательный буффер

    public GameObject[] del;
    public GameObject for_deleting_figure;

    public GameObject cell;     // набор обьектов для дальнейшей их визуализации
    public Renderer for_cell;   // renderer для смены материала на 'cell'е 
        private bool black = true; // вспомогательная переменная для cell
    public GameObject pawn;
        public Renderer pawn_r;
    public GameObject knight;
        public Renderer knight_r;
    public GameObject bishop;
        public Renderer bishop_r;
    public GameObject rook;
        public Renderer rook_r;
    public GameObject queen;
        public Renderer queen_r;
    public GameObject king;
        public Renderer king_r;

    public Material white_mat;  // белый материал
    public Material black_mat;  // черный материал


    void Awake()    // при создании кадра происходит до Start 
    {
        filing_table();
    }

    void filing_table()    // заполняем доску
    {
        for (int i = 0; i < 8; i++) // заполнение всей доски пустыми значениями
        {
            for (int j = 0; j < 8; j++)
            {
                empty emp = new empty();
                emp.figure_name = emp.name;
                board[i, j] = emp;

            }
        }

        for (int i = 0; i < 8; i++) // заполнение первой строки белыми пешками
        {
            pawn pn = new pawn();
            pn.colors_of_figure = 0;
            pn.figure_name = pn.name;
            board[1, i] = pn;
        }


        rook rk = new rook();
        rk.colors_of_figure = 0;    // белые ладьи
        rk.figure_name = rk.name;
            board[0, 0] = rk;
            board[0, 7] = rk;
        

        rook rk_black = new rook();
        rk_black.colors_of_figure = 1;    // чёрные ладьи
        rk_black.figure_name = rk_black.name;
            board[7, 0] = rk_black;
            board[7, 7] = rk_black;

       

        knight kn = new knight();
        kn.colors_of_figure = 0;    // белые кони
        kn.figure_name = kn.name;
        board[0, 1] = kn;
        board[0, 6] = kn;

        knight kn_black = new knight();
        kn_black.colors_of_figure = 1;    // черные кони
        kn_black.figure_name = kn_black.name;
        board[7, 1] = kn_black;
        board[7, 6] = kn_black;

       

        bishop bs = new bishop();
        bs.colors_of_figure = 0;    // белые слоны
        bs.figure_name = bs.name;
        board[0, 2] = bs;
        board[0, 5] = bs;

        bishop bs_black = new bishop();
        bs_black.colors_of_figure = 1;    // черные слоны
        bs_black.figure_name = bs_black.name;
        board[7, 2] = bs_black;
        board[7, 5] = bs_black;

        queen q = new queen();   // белая королева
        q.colors_of_figure = 0;
        q.figure_name = q.name;
        board[0, 3] = q;

        queen q_black = new queen();     // черная королева
        q_black.colors_of_figure = 1;
        q_black.figure_name = q_black.name;
        board[7, 3] = q_black;           

        king kg = new king();
        kg.colors_of_figure = 0;    // белый король
        kg.figure_name = kg.name;
        board[0, 4] = kg;

        king kg_black = new king();
        kg_black.colors_of_figure = 1;    // черный король
        kg_black.figure_name = kg_black.name;
        board[7, 4] = kg_black;


        for (int i = 0; i < 8; i++) // заполнение 7ой строки черными пешками
        {
            pawn pn = new pawn();
            pn.colors_of_figure = 1;
            pn.figure_name = pn.name;
            board[6, i] = pn;
        }

       
        
    }

    void Start()    
    {
        
        UpdateFigures();
    }

    void Update() 
    {

        if (Input.GetKeyUp(KeyCode.A))
        {
            
           DeleteFigures();
           UpdateFigures();

        }
      
    }

    void LateUpdate() 
    {
       
    }

    void UpdateFigures()    // Визуальная часть (сделано), 
    //после каждого хода вызываем для обновления отображения фигур
    {
        


            for (int z = 0; z < 8; z++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (z == 0 || z == 2 || z == 4 || z == 6)
                    {
                        if (black)
                        {
                            for_cell.material = black_mat;
                            black = false;
                        }
                        else
                        {
                            for_cell.material = white_mat;
                            black = true;
                        }

                    }
                    else
                    {

                        if (black)
                        {
                            for_cell.material = white_mat;
                            black = false;

                        }
                        else
                        {

                            for_cell.material = black_mat;
                            black = true;
                        }

                    }


                    Instantiate(cell, new Vector3(x, 0, z), Quaternion.identity);


                    if (board[z, x].figure_name == "empty")
                    {



                    }

                    if (board[z, x].figure_name == "pawn")
                    {

                        if (board[z, x].colors_of_figure == 1)
                        {
                            pawn_r.material = black_mat;
                        }
                        else
                        {
                            pawn_r.material = white_mat;
                        }

                        Instantiate(pawn, new Vector3(x, 0, z), transform.rotation);
                        pawn.tag = "Figure";
                    }

                    if (board[z, x].figure_name == "knight")
                    {

                        if (board[z, x].colors_of_figure == 1)
                        {
                            knight_r.material = black_mat;
                        }
                        else
                        {
                            knight_r.material = white_mat;
                        }

                        Instantiate(knight, new Vector3(x, 0, z), transform.rotation);
                        knight.tag = "Figure";
                    }

                    if (board[z, x].figure_name == "bishop")
                    {

                        if (board[z, x].colors_of_figure == 1)
                        {
                            bishop_r.material = black_mat;
                        }
                        else
                        {
                            bishop_r.material = white_mat;
                        }

                        Instantiate(bishop, new Vector3(x, 0, z), transform.rotation);
                        bishop.tag = "Figure";
                    }

                    if (board[z, x].figure_name == "rook")
                    {

                        if (board[z, x].colors_of_figure == 1)
                        {
                            rook_r.material = black_mat;
                        }
                        else
                        {
                            rook_r.material = white_mat;
                        }

                        Instantiate(rook, new Vector3(x, 0, z), transform.rotation);
                        rook.tag = "Figure";
                    }

                    if (board[z, x].figure_name == "queen")
                    {

                        if (board[z, x].colors_of_figure == 1)
                        {
                            queen_r.material = black_mat;
                        }
                        else
                        {
                            queen_r.material = white_mat;
                        }

                        Instantiate(queen, new Vector3(x, 0, z), transform.rotation);
                        queen.tag = "Figure";
                    }

                    if (board[z, x].figure_name == "king")
                    {

                        if (board[z, x].colors_of_figure == 1)
                        {
                            king_r.material = black_mat;
                        }
                        else
                        {
                            king_r.material = white_mat;
                        }

                        Instantiate(king, new Vector3(x, 0, z), transform.rotation);
                        king.tag = "Figure";
                    }
                }
            }
    }

    void DeleteFigures()
    {
      del = GameObject.FindGameObjectsWithTag("Figure");
      for (int i = 0; i < del.Length; i++)
      {
          Destroy(del[i]);
      }
      

    }

    public void MoveFigure(figure active_figure, int x, int y)
    {



    }
   
    void Checking_For_Possible_Moves(int number_of_figure, int x, int z)
    {
        
            switch (number_of_figure)
            {
                case 0: // клетка пуста
                   
                    break;

                case 1: // пешка (pawn)
                  

                        break;

                case 2: // ладья (rook)
                       
                    break;

                case 3: //  конь (knight)
                   
                    break;
                case 4: //  слон (bishop)
                    
                    break;

                case 5: //  королева (queen)
                   

                    break;

                case 6: //  король (king)
                   

                    break;

        }

    }

}
