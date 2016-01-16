using UnityEngine;
using System.Collections;

public class king_alert : MonoBehaviour {

    public GameObject lol;


    IEnumerator Example() {
        
        yield return new WaitForSeconds(1);
        lol.SetActive(false);
    }

    void Update()
    {
        StartCoroutine(Example());

    }

    
}
