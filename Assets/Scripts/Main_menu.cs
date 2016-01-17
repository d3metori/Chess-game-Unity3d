using UnityEngine;
using System.Collections;

// Сделано студентом Группы П-304 Терентьевым Дмитрием
/// <summary>
/// Для главного меню, хранит в себе ui 
/// </summary>
public class Main_menu : MonoBehaviour {

    public GameObject _ui_start;    //Start_ui
    public GameObject _ui_exit;     //Exit_ui

    public GameObject _ui_play;     //Play_ui
    public GameObject _ui_back;     //Back_ui

    public GameObject _ui_play_black; // начать игру за черных
    public GameObject _ui_play_white; // начать игру за белых

    public GameObject stateOBJ;

    /// <summary>
    /// ищем statemessenger
    /// </summary>
    void Awake()
    {
        stateOBJ = GameObject.Find("StateMessanger");
        


    }
    /// <summary>
    /// выход
    /// </summary>
   public void Exit_Game()
    {
        Application.Quit();
    }

    /// <summary>
    /// к меню выбора цвета
    /// </summary>
   public void Start_Game()
   {
       
       _ui_start.SetActive(false);
       _ui_exit.SetActive(false);

     //  _ui_play.SetActive(true);
       _ui_back.SetActive(true);
       _ui_play_black.SetActive(true);
       _ui_play_white.SetActive(true);
   }
    /// <summary>
    /// начать игру
    /// </summary>
   public void Play_Game()
   {
       Application.LoadLevel("Scene");
   }
    /// <summary>
    /// назад
    /// </summary>
   public void Back_to_menu()
   {
       _ui_start.SetActive(true);
       _ui_exit.SetActive(true);

       _ui_play.SetActive(false);
       _ui_back.SetActive(false);
       _ui_play_black.SetActive(false);
       _ui_play_white.SetActive(false);
   }
    /// <summary>
    /// играть за черных
    /// </summary>
   public void PlayAsBlack()
   {

       SenderState scriptToAccess = stateOBJ.GetComponent<SenderState>();
       scriptToAccess.SetColor(1);
       Debug.Log("Color setted is 1");
       Application.LoadLevel("Scene");
      

   }
    /// <summary>
    /// играть за белых
    /// </summary>
   public void PlayAsWhite()
   {
       SenderState scriptToAccess = stateOBJ.GetComponent<SenderState>();
       scriptToAccess.SetColor(0);
       Debug.Log("Color setted is 0");
       Application.LoadLevel("Scene");
     

   }

}
