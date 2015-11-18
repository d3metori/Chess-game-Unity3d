using UnityEngine;
using System.Collections;

public class square : MonoBehaviour {


        public int[] position;  // позиция данной клетки где [0] - x(строка)   [1] - z(столбец)
        public bool Empty;
        public enum colors { white = 1, black = 2 };    // дабы не считать с нуля
        public colors colors_of_square;

        public Material[] materials;    // 1 - white 2 - black
        public Renderer rend;

        colors ReverseDirection(colors dir)
        {
            if (colors_of_square == colors.white){
                rend.sharedMaterial = materials[0];
              //  Debug.Log("changed to mat [0]");
            }

            if (colors_of_square == colors.black) {
                rend.sharedMaterial = materials[1];
               // Debug.Log("changed to mat [1]");
            }
             
                return dir;
        }

       
    void Start(){

         ReverseDirection(colors_of_square);
         figure fiq = new figure();

         fiq.colors_of_figure = 0;
         Debug.Log(fiq.colors_of_figure);

     }
   }
