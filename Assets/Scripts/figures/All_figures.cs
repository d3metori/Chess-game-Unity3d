// Код студента группы 304 Терентьева Дмитрия
using UnityEngine;
using System.Collections;

public class All_figures : MonoBehaviour {

	public class figures{

		public bool king;	//король
		public bool queen;  //королева/ферзь
		public bool bishop; //слон
		public bool knight; //конь
		public bool rook;	//ладья
		public bool pawn;	//пешка

		public figures(bool k, bool q, bool b, bool kn, bool r, bool p){

			king = k;
			queen = q;
			bishop = b;
			knight = kn;
			rook = r;	
			pawn = p;

		}
	}

	public figures fig = new figures(false,false,false,false,false,false);

	void Start(){

	}




}
