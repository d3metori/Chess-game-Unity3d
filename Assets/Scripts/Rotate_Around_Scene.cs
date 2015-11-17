using UnityEngine;
using System.Collections;

// Создано Студентом группы П-304 Терентьев Д.

public class Rotate_Around_Scene : MonoBehaviour {

    public Transform point_of_rotating;
    public float sensitivityX, sensitivityY = 15f;
    public float speed = 10f;
    private float rotationX = 0f;
    private bool entered_r = false;     //For left panel
    private bool entered_l = false;     //For right panel
    
	// Update is called once per frame
	void Update () {
        Rotating();
	}

    void Rotating()
    {

        if (entered_r)
        {
            transform.RotateAround(point_of_rotating.transform.position, new Vector3(0, -1, 0), 20 * Time.deltaTime * speed);
        }

        if (entered_l)
        {
            transform.RotateAround(point_of_rotating.transform.position, new Vector3(0, 1, 0), 20 * Time.deltaTime * speed);
        }

    }

    public void OnEnterRight()
    {
        entered_r = true;
    }

    public void OnEnterLeft()
    {
        entered_l = true;
    }

    public void OnExitLeft()
    {
        entered_l = false;
    }
    public void OnExitRight()
    {
        entered_r = false;
    }

}
