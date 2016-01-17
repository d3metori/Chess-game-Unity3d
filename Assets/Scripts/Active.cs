using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Active : MonoBehaviour
{

    public Renderer rend;
    public Material default_mat;
    public Material mat;
    public Material second_mat;
    public GameObject Core_object;
    private int first_number;
    private int second_number;

    private bool first_active;
    private bool second_active;

    
    void Awake()
    {
        Core_object = GameObject.Find("Core");
        default_mat = rend.material;

        first_number = (int)this.transform.position.z;
        second_number = (int)this.transform.position.x;

    }

    void LateUpdate()
    {

        Core scriptToAccess = Core_object.GetComponent<Core>();

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {

                if (scriptToAccess.board[first_number, second_number].active == false)
                {
                    rend.material = default_mat;
                }
            }
        }
        
    }

    void OnMouseUp()        // будет работать только если мы белые
    {


        Core scriptToAccess = Core_object.GetComponent<Core>();

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {

                if (scriptToAccess.board[first_number, second_number].active == false)
                {
                    rend.material = default_mat;
                }
            }
        }
 


        if (scriptToAccess.State == 0)
        {
            if (scriptToAccess.board[first_number, second_number].colors_of_figure == 0)
            {


                if (!first_active)  // если не выбрана первая фигура, то мы вибираем ее
                {
           
                    if (scriptToAccess.board[first_number, second_number].figure_name != "empty")   // пустая фигура не может быть выделена для движения
                    {
                        scriptToAccess.ActivateFigure(this.transform.position.z, this.transform.position.x);
                        scriptToAccess.z = (int)this.transform.position.z;
                        scriptToAccess.x = (int)this.transform.position.x;
                        first_active = true;
                        scriptToAccess.CheckFirstActive();
                        Debug.Log("activated figure is");
                        Debug.Log(scriptToAccess.board[scriptToAccess.z, scriptToAccess.x]);
                        Changing_First_Materials();

                      //  scriptToAccess.DebuggingStats(first_number, second_number);

                    }
                }
            }

            // если фигура пустая то выбираем ее как второе значение, если нет выбираем как первое и если цвет черный то как 2ую выбираем
            if (scriptToAccess.FirstActiveted)
            {
                if (scriptToAccess.board[first_number, second_number].figure_name == "empty")
                {
                    scriptToAccess.SecondActivateFigure(this.transform.position.z, this.transform.position.x);
                    scriptToAccess.second_z = (int)this.transform.position.z;
                    scriptToAccess.second_x = (int)this.transform.position.x;
                    scriptToAccess.isMoveCanBe(scriptToAccess.board[scriptToAccess.z, scriptToAccess.x].figure_name, scriptToAccess.board[first_number, second_number].colors_of_figure);
                    second_active = true;

                    
                }

                else
                {
                    if (scriptToAccess.board[first_number, second_number].colors_of_figure == 1)    // Надо вызывать атаку
                    {
                        scriptToAccess.SecondActivateFigure(this.transform.position.z, this.transform.position.x);
                        scriptToAccess.second_z = (int)this.transform.position.z;
                        scriptToAccess.second_x = (int)this.transform.position.x;
                        scriptToAccess.isMoveCanBe(scriptToAccess.board[scriptToAccess.z, scriptToAccess.x].figure_name, scriptToAccess.board[first_number, second_number].colors_of_figure);
                        second_active = true;
                        
                    }
                    else
                    {

                        scriptToAccess.ActivateFigure(this.transform.position.z, this.transform.position.x);
                        Changing_First_Materials();
                        scriptToAccess.z = (int)this.transform.position.z;
                        scriptToAccess.x = (int)this.transform.position.x;
                        first_active = true;

                    }
                }
            }   // color
            else
            {   // пишем атаку
                


            }

        }   // state

    }

    void Changing_First_Materials()
    {
        Core scriptToAccess = Core_object.GetComponent<Core>();
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {

                rend.material = default_mat;

            }
        }


        if (scriptToAccess.board[first_number, second_number].active)
        {
            this.rend.material = mat;
        }

    }
     
}