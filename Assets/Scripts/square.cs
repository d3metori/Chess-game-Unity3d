using UnityEngine;
using System.Collections;

public class square : MonoBehaviour {


        public int[] position;  // позиция данной клетки где [1] - x(строка)   [2] - z(столбец)

        public bool Empty;
        public enum Components { First, Second};
        public Components zz;


        Components ReverseDirection(Components dir)
        {
            if (dir == Components.First)
                dir = Components.First;
            else if (dir == Components.Second)
                dir = Components.Second;

            return dir;
        }

       
    void Start(){
         //figure = Components.First;
         ReverseDirection(zz);
         Debug.Log(zz);

         figure fiq = new figure();
         fiq.color = true;
         Debug.Log(fiq.color);

     }
    

   }
