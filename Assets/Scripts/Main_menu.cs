using UnityEngine;
using System.Collections;

public class Main_menu : MonoBehaviour {

    public GameObject _ui_start;    //Start_ui
    public GameObject _ui_load;     //Load_ui
    public GameObject _ui_exit;     //Exit_ui

    public GameObject _ui_play;     //Play_ui
    public GameObject _ui_back;     //Back_ui

   public void Exit_Game()
    {
        Application.Quit();
    }

   public void Start_Game()
   {
       _ui_start.SetActive(false);
       _ui_load.SetActive(false);
       _ui_exit.SetActive(false);

       _ui_play.SetActive(true);
       _ui_back.SetActive(true);
   }

   public void Load_Game()
   {
     /*  _ui_start.SetActive(false);
       _ui_load.SetActive(false);
       _ui_exit.SetActive(false);

       _ui_play.SetActive(true);
       _ui_back.SetActive(true);*/
   }

   public void Play_Game()
   {
       Application.LoadLevel("Scene");
   }

   public void Back_to_menu()
   {
       _ui_start.SetActive(true);
       _ui_load.SetActive(true);
       _ui_exit.SetActive(true);

       _ui_play.SetActive(false);
       _ui_back.SetActive(false);
   }
}
