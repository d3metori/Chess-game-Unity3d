using UnityEngine;
using System.Collections;

public class pawn : figure
{    //пешка

    public bool direction; // true - white to black else reverse
    public string name = "pawn";
    public bool first_move = true; // если первый шаг пешки за игру то +1 возможный ход

    public void possible_moves(){


    }
	
}
