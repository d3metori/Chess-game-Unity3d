using UnityEngine;
using System.Collections;

// Сделано студентом Группы П-304 Терентьевым Дмитрием
/// <summary>
/// Для выбирания цвета фигур
/// </summary>
public class SenderState : MonoBehaviour {

    public int color; // 0 or 1
    public GameObject AIOBJ;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    /// <summary>
    /// сюда ставится цвет из главного меню
    /// </summary>
    /// <param name="colorr">нужный цвет 0 или 1 (белый и черный соответственно)</param>
    public void SetColor(int colorr) // сюда ставится цвет из главного меню -> чекай скрипт с менюшкой
    {
        color = colorr;
    }
       
}
