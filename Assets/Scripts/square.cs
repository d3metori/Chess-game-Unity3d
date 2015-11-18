using UnityEngine;
using System.Collections;

public class square : MonoBehaviour {


        public int[,] position;  // позиция данной клетки где x(строка) z(столбец)
        public bool Empty;
        public int colors;   // 0 - white 1- black 

        public Material[] materials;    // 0 - white 1 - black
        public Renderer rend;

        int ReverseDirection()
        {
            if (colors == 0){
                rend.sharedMaterial = materials[0];
              //  Debug.Log("changed to mat [0]");
            }

            if (colors == 1) {
                rend.sharedMaterial = materials[1];
               // Debug.Log("changed to mat [1]");
            }
             
                return 0;
        }

       
    void Start(){

         ReverseDirection();

         figure fiq = new figure();
         fiq.colors_of_figure = 0;
         Debug.Log(fiq.colors_of_figure);

     }
   }
