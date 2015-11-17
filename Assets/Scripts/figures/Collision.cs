using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {

	public bool empty = true; //путая ли ячейка
	public bool change_figure = false; //можно ли в данной ячейке изменить пешку на другие фигуры

	[Header("Collision as figure")]
	public bool king;	//король
	public bool queen;  //королева/ферзь
	public bool bishop; //слон
	public bool knight; //конь
	public bool rook;	//ладья
	public bool pawn;	//пешка


	[Header("Object of figure")]
	[Space(10)]
	public GameObject king_obj;	//король
	public GameObject queen_obj;  //королева/ферзь
	public GameObject bishop_obj; //слон
	public GameObject knight_obj; //конь
	public GameObject rook_obj;	//ладья
	public GameObject pawn_obj;	//пешка




}
