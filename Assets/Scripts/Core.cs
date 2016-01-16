using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

// Сделано студентом Группы П-304 Терентьевым Дмитрием

public class Core : MonoBehaviour
{
    public GameObject stateOBJ;
    public GameObject AIOBJ;

    public int moves = 0;

    public int State = 0; // 0,1  0 - наш ход, 1 - ход врага
    public int State2 = 1;  // наш цвет -- 0 - белый 1 - черный
    public bool move_updated = false; //для визуального обновления всех фигур
    public bool first_time_updated = false; // вспомогательная переменная для move_updated
    public figure[,] board = new figure[8, 8]; // доска
    public figure buffer;   // вспомогательный буффер

    public GameObject[] del;
    public GameObject for_deleting_figure;

    public bool FirstActiveted = false; // активирована ли первая фигура

    public int kings = 2; // кол-во королей

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
    public GameObject empty_obj;
    public Renderer empty_r;

    public GameObject king_alert;

    public int z;    // позиции активированных фигур
    public int x;

    public int second_z;
    public int second_x;


    public Material white_mat;  // белый материал
    public Material buff_mat;
    public Material black_mat;  // черный материал

    void SetGameSettings()  // данная функция существует для того ччтобы понять черные мы или белые. 
    {
        if (State2 == 0)
        {
            Debug.Log("Мы белые");
            State = 0;
        }
        else
        {
            Debug.Log("Мы черные");

            buff_mat = white_mat;
            white_mat = black_mat;
            black_mat = buff_mat;
            State = 1;
        }

    }

    void Awake()    // при создании кадра происходит до Start 
    {
        DontDestroyOnLoad(this.gameObject);

        AIOBJ = GameObject.Find("AI");
        stateOBJ = GameObject.Find("StateMessanger");
        SenderState scriptToAccessOBJ = stateOBJ.GetComponent<SenderState>();
        State2 = scriptToAccessOBJ.color;
        State = scriptToAccessOBJ.color;
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
            pn.direction = false;
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
            pn.direction = true;
            board[6, i] = pn;
        }



    }

    void Start()
    {
        SetGameSettings();
        UpdateFigures();

        stateOBJ = GameObject.Find("StateMessanger");
        SenderState scriptToAccessOBJ = stateOBJ.GetComponent<SenderState>();
        if (scriptToAccessOBJ.color == 1)   // если изначальный цвет 1 то мы передаем ход АИ
        {
            To_AI();
        }
    }

    void Update()
    {

        

        if (Input.GetKeyUp(KeyCode.A))
        {
            DebuggingStats(z, x);

        }


    }

    public void UpdateFigures()    // Визуальная часть, после каждого хода вызываем для обновления отображения фигур
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

                    Instantiate(empty_obj, new Vector3(x, 0, z), transform.rotation);


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

    public void DeleteFigures()    // Удаление фигур
    {
        del = GameObject.FindGameObjectsWithTag("Figure");
        for (int i = 0; i < del.Length; i++)
        {
            Destroy(del[i]);
        }
    }

    public void MoveFigure()    // двигает 2 текущие активные фигуры
    {
        moves++;

        DebuggingStats(z, x);

        if (board[second_z, second_x].figure_name == "empty")    // просто двигаем
        {
            buffer = board[z, x];
            board[z, x] = board[second_z, second_x];
            board[second_z, second_x] = buffer;

           // Debug.Log("moved");

        }

        DeleteFigures();
        UpdateFigures();

       // Debug.Log(board[z, x].figure_name);
      //  Debug.Log(board[second_z, second_x].figure_name);

        board[z, x].isSecondActive = false;
        board[z, x].active = false;

        board[second_z, second_x].isSecondActive = false;
        board[second_z, second_x].active = false;



        
  
        if (State == 0)
        {
            To_AI();
        }


    }

    public void RokirovkaMove()
    {
        
        if (board[z, x].figure_name == "king")
        {
            if (z == 0 & x == 4)
            {
                if(second_z == 0 & second_x == 2){

                    buffer = board[0, 0];
                    board[0, 0] = board[0, 3];
                    board[0, 3] = buffer;
                 
                }
            }
        }


        if (board[z, x].figure_name == "king")
        {
            if (z == 0 & x == 4)
            {
                if (second_z == 0 & second_x == 6)
                {

                    buffer = board[0, 7];
                    board[0, 7] = board[0, 5];
                    board[0, 5] = buffer;

                }
            }
        }


        if (board[z, x].figure_name == "king")
        {
            if (z == 7 & x == 4)
            {
                if (second_z == 7 & second_x == 2)
                {

                    buffer = board[7, 7];
                    board[7, 7] = board[7, 3];
                    board[7, 3] = buffer;

                }
            }
        }


        if (board[z, x].figure_name == "king")
        {
            if (z == 7 & x == 4)
            {
                if (second_z == 7 & second_x == 6)
                {

                    buffer = board[7, 7];
                    board[7, 7] = board[7, 5];
                    board[7, 5] = buffer;

                }
            }
        }

    }

    public void AttackFigure()  // атака
    {
        empty empt = new empty();

        if (board[second_z, second_x].figure_name == "king")
        {
            Application.LoadLevel("End");
        }

        board[second_z, second_x] = empt;
        MoveFigure();
    }

    public void isMoveCanBe(string name, int color)   // вызывается если активны уже 2 фигуры и проверяется что с ними делать
    {
        if (State == 0)
        {
            if (name == "pawn")
            {
               // Debug.Log("nameCorrect");
                if (color == 0)
                {
                  //  Debug.Log("colorCorrect");
                    pawn pn = new pawn();
                    if (board[z, x].first_move == false)
                    {
                        pn.first_move = false;
                    }

                    pn.PossibleMoves(z, x);

                    for (int i = 0; i < pn.P_Moves.Count; i++)
                    {

                        if (pn.P_Moves[i].z == second_z & pn.P_Moves[i].x == second_x)
                        {
                            board[z, x].first_move = false;
                            MoveFigure();
                        }

                    }
                }
                else // color == 1
                {
                    pawn pn = new pawn();
                    pn.PossibleMoves(z, x);

                    for (int i = 0; i < pn.Attack_Moves.Count; i++)
                    {


                        if (pn.Attack_Moves[i].z == second_z & pn.Attack_Moves[i].x == second_x)
                        {
                            AttackFigure();
                        }
                    }
                }
            }


            if (name == "queen")
            {
               // Debug.Log("nameCorrect");


              //  Debug.Log("colorCorrect");
                queen q = new queen();

                q.PossibleMoves(z, x);

                for (int i = 0; i < q.P_Moves_Up.Count; i++)
                {
                    if (q.P_Moves_Up[i].z == second_z & q.P_Moves_Up[i].x == second_x)
                    {
                        if (color == 0)
                        {

                            MoveFigure();
                        }
                        else
                        {
                            AttackFigure();
                        }

                    }
                }

                for (int i = 0; i < q.P_Moves_Down.Count; i++)
                {
                    if (q.P_Moves_Down[i].z == second_z & q.P_Moves_Down[i].x == second_x)
                    {
                        if (color == 0)
                        {
                            MoveFigure();
                        }
                        else
                        {
                            AttackFigure();
                        }
                    }
                }

                for (int i = 0; i < q.P_Moves_Left.Count; i++)
                {
                    if (q.P_Moves_Left[i].z == second_z & q.P_Moves_Left[i].x == second_x)
                    {
                        if (color == 0)
                        {
                            MoveFigure();
                        }
                        else
                        {
                            AttackFigure();
                        }
                    }
                }

                for (int i = 0; i < q.P_Moves_Right.Count; i++)
                {

                    if (q.P_Moves_Right[i].z == second_z & q.P_Moves_Right[i].x == second_x)
                    {
                        if (color == 0)
                        {
                            MoveFigure();
                        }
                        else
                        {
                            AttackFigure();
                        }
                    }
                }

                for (int i = 0; i < q.P_Moves_LeftUp.Count; i++)
                {
                    if (q.P_Moves_LeftUp[i].z == second_z & q.P_Moves_LeftUp[i].x == second_x)
                    {
                        if (color == 0)
                        {
                            MoveFigure();
                        }
                        else
                        {
                            AttackFigure();
                        }
                    }
                }

                for (int i = 0; i < q.P_Moves_RightUp.Count; i++)
                {
                    if (q.P_Moves_RightUp[i].z == second_z & q.P_Moves_RightUp[i].x == second_x)
                    {
                        if (color == 0)
                        {
                            MoveFigure();
                        }
                        else
                        {
                            AttackFigure();
                        }
                    }
                }


                for (int i = 0; i < q.P_Moves_RightDown.Count; i++)
                {
                    if (q.P_Moves_RightDown[i].z == second_z & q.P_Moves_RightDown[i].x == second_x)
                    {
                        if (color == 0)
                        {
                            MoveFigure();
                        }
                        else
                        {
                            AttackFigure();
                        }
                    }
                }

                for (int i = 0; i < q.P_Moves_LeftDown.Count; i++)
                {
                    if (q.P_Moves_LeftDown[i].z == second_z & q.P_Moves_LeftDown[i].x == second_x)
                    {
                        if (color == 0)
                        {
                            MoveFigure();
                        }
                        else
                        {
                            AttackFigure();
                        }
                    }
                }
            }

            if (name == "king")
            {
                king k = new king();

                k.PossibleMoves(z, x);

                for (int i = 0; i < k.P_Moves.Count; i++)
                {
                    if (k.P_Moves[i].z == second_z & k.P_Moves[i].x == second_x)
                    {
                        if (color == 0)
                        {

                            MoveFigure();
                        }
                        else
                        {
                            AttackFigure();
                        }
                    }
                }

                for (int i = 0; i < k.P_Moves_r.Count; i++)
                {
                    if (k.P_Moves_r[i].z == second_z & k.P_Moves_r[i].x == second_x)
                    {
                        RokirovkaMove();
                        MoveFigure();
                    }
                }
            }


            if (name == "rook")
            {
                rook rk = new rook();

                rk.PossibleMoves(z, x);

                for (int i = 0; i < rk.P_Moves_Up.Count; i++)
                {
                    if (rk.P_Moves_Up[i].z == second_z & rk.P_Moves_Up[i].x == second_x)
                    {
                        if (color == 0)
                        {
                            MoveFigure();
                        }
                        else
                        {
                            AttackFigure();
                        }
                    }
                }

                for (int i = 0; i < rk.P_Moves_Down.Count; i++)
                {
                    if (rk.P_Moves_Down[i].z == second_z & rk.P_Moves_Down[i].x == second_x)
                    {
                        if (color == 0)
                        {
                            MoveFigure();
                        }
                        else
                        {
                            AttackFigure();
                        }
                    }
                }

                for (int i = 0; i < rk.P_Moves_Left.Count; i++)
                {
                    if (rk.P_Moves_Left[i].z == second_z & rk.P_Moves_Left[i].x == second_x)
                    {
                        if (color == 0)
                        {
                            MoveFigure();
                        }
                        else
                        {
                            AttackFigure();
                        }
                    }
                }

                for (int i = 0; i < rk.P_Moves_Right.Count; i++)
                {

                    if (rk.P_Moves_Right[i].z == second_z & rk.P_Moves_Right[i].x == second_x)
                    {
                        if (color == 0)
                        {
                            MoveFigure();
                        }
                        else
                        {
                            AttackFigure();
                        }
                    }
                }
            }


            if (name == "bishop")
            {
                bishop q = new bishop();

                q.PossibleMoves(z, x);

                for (int i = 0; i < q.P_Moves_LeftUp.Count; i++)
                {
                    if (q.P_Moves_LeftUp[i].z == second_z & q.P_Moves_LeftUp[i].x == second_x)
                    {
                        if (color == 0)
                        {
                            MoveFigure();
                        }
                        else
                        {
                            AttackFigure();
                        }
                    }
                }

                for (int i = 0; i < q.P_Moves_RightUp.Count; i++)
                {
                    if (q.P_Moves_RightUp[i].z == second_z & q.P_Moves_RightUp[i].x == second_x)
                    {
                        if (color == 0)
                        {
                            MoveFigure();
                        }
                        else
                        {
                            AttackFigure();
                        }
                    }
                }


                for (int i = 0; i < q.P_Moves_RightDown.Count; i++)
                {
                    if (q.P_Moves_RightDown[i].z == second_z & q.P_Moves_RightDown[i].x == second_x)
                    {
                        if (color == 0)
                        {
                            MoveFigure();
                        }
                        else
                        {
                            AttackFigure();
                        }
                    }
                }

                for (int i = 0; i < q.P_Moves_LeftDown.Count; i++)
                {
                    if (q.P_Moves_LeftDown[i].z == second_z & q.P_Moves_LeftDown[i].x == second_x)
                    {
                        if (color == 0)
                        {
                            MoveFigure();
                        }
                        else
                        {
                            AttackFigure();
                        }
                    }
                }
            }


            if (name == "knight")
            {
                knight q = new knight();

                q.PossibleMoves(z, x);

                for (int i = 0; i < q.P_Moves.Count; i++)
                {
                    if (q.P_Moves[i].z == second_z & q.P_Moves[i].x == second_x)
                    {
                        if (color == 0)
                        {
                            if (color == 0)
                            {
                                MoveFigure();
                            }
                            else
                            {
                                AttackFigure();
                            }
                        }
                        else
                        {
                            if (color == 0)
                            {
                                MoveFigure();
                            }
                            else
                            {
                                AttackFigure();
                            }
                        }
                    }
                }
            }
        }
    }


    public void ActivateFigure(float z, float x)
    {
        if (State == 0)  // если ход наш
        {
            int first_number = (int)z;
            int second_number = (int)x;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {

                    board[i, j].active = false;

                }
            }

            board[first_number, second_number].active = true;

        }
    }

    public void CheckFirstActive()
    {
        FirstActiveted = false;

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {

                if (board[i, j].active == true)
                {
                    FirstActiveted = true;
                }
            }
        }

    }
    public void SecondActivateFigure(float z, float x)
    {
        if (State == 0)  // если ход наш
        {
            int first_number = (int)z;
            int second_number = (int)x;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {

                    board[i, j].isSecondActive = false;

                }
            }

            board[first_number, second_number].isSecondActive = true;
          //  Debug.Log("second");
          //  Debug.Log(board[first_number, second_number].figure_name);
        }
    }

    public void DebuggingStats(int z, int x)    // отправляем координаты фигуры, получаем все статы на ней
    {

        Debug.Log(board[z, x].figure_name);
        Debug.Log("color");
        Debug.Log(board[z, x].colors_of_figure);
        Debug.Log(board[z, x].active);
        Debug.Log(board[z, x].isSecondActive);

    }

    public void setGlobalPlayerColor(int color)
    {
        State2 = color;

    }

    public void To_AI() // Даем знать ИИ что сейчас его ход
    {
        AI script_AI = AIOBJ.GetComponent<AI>();
        State = 1;
        script_AI.StartThinking();
    }



}
    
