using UnityEngine;
using System.Collections;

public class Core : MonoBehaviour {

    private int State = 0; // 0,1,2  0 - ход белых, 1 - ход черных, 2 - игра стоит на паузе(в режиме ожидания) 
    public GameObject cell;

    void Awake()    // при создании кадра происходит до Start 
    {
        filing_table();
    }

    void filing_table()    // заполняем доску
    {
        figure fiq = new figure();

    }

       
    }
}
