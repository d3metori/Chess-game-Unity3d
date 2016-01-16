using UnityEngine;
using System.Collections;

public class zxc : MonoBehaviour {

    public GameObject Core_object;



	// Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            Core_object = GameObject.Find("Core");
            Core scriptToAccess = Core_object.GetComponent<Core>();

          //  scriptToAccess.State = 1;
            king kg = new king();
            kg.colors_of_figure = 0;
            kg.PossibleMoves(0,4);
            

            //Debug.Log("zc");
           // Debug.Log(p.P_Moves.Count);
            
        }
    }
	
}
