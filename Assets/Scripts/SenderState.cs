using UnityEngine;
using System.Collections;

// Сделано студентом Группы П-304 Терентьевым Дмитрием

public class SenderState : MonoBehaviour {

    public int color; // 0 or 1
    public GameObject AIOBJ;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void SetColor(int colorr) // сюда ставится цвет из главного меню -> чекай скрипт с менюшкой
    {
        color = colorr;
    }
       
}
