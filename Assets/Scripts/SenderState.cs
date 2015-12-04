using UnityEngine;
using System.Collections;

public class SenderState : MonoBehaviour {

    public int color; // 0 or 1

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void SetColor(int new_color) 
    {
        color = new_color;
    }
       
}
