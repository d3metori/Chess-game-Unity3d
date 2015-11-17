// Код студента группы 304 Терентьева Дмитрия
using UnityEngine;
using System.Collections;

public class grid : MonoBehaviour {

	public GameObject block_white;
	public GameObject block_help;
	public GameObject block_black;
	
	public bool changeMat = true;
	
	void Start () {
		for (int z = 0; z<8; z++) {
			for (int x = 0; x<8; x++) {
				if(changeMat){
				Instantiate (block_white, new Vector3 (z, 0, x), Quaternion.identity);
				changeMat = false;
				}else{
				Instantiate (block_black, new Vector3 (z, 0, x), Quaternion.identity);
				changeMat = true;
				}
			}

			block_help = block_black;
			block_black = block_white;
			block_white = block_help;

		}
	}
}