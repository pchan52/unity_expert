using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyweightTestUsed : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    var document = "iamaman";
	    var chars = document.ToCharArray();

	    var letterFactory = new LetterFactory();

	    foreach (var c in chars)
	    {
	        CharLetter charletter = letterFactory.GetLetter(c);
	        ShowCharLetter(charletter);
	    }
	}


    private void ShowCharLetter(CharLetter letter)
    {
        Debug.Log(letter.Singleletter);
    }
}
