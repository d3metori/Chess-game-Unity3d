using UnityEngine;
using System.Collections;

public class Core : MonoBehaviour {

    private int State = 0; // 0,1,2  0 - ход белых, 1 - ход черных, 2 - игра стоит на паузе(в режиме ожидания) 
    public GameObject cell;

    void Awake()    // при создании кадра происходит до Start 
    {
        GenerateTable();
    }

    void GenerateTable()    // генерируем доску
    {
        for (int z = 0; z < 8; z++){
            for(int x=0; x < 8; x++){

                if (z % 2 == 0) //четное
                {
                    if (x % 2 == 0) //четное
                    {
                        Instantiate(cell, new Vector3(x, 0, z), Quaternion.identity);
                        cell.GetComponent<square>().colors = 1;
                     

                    }
                    else    // если x не четный
                    {
                        Instantiate(cell, new Vector3(x, 0, z), Quaternion.identity);
                        cell.GetComponent<square>().colors = 0;

                    }

                }
                else    //если z не четный
                {


                }
            }
        }


    }

	void Start () {

        Debug.Log(4%3);
	}
	
}
