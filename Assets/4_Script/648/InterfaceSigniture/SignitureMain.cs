using UnityEngine;

public class SignitureMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    InterfaceSigniture ifs = new InterfaceSigniture();
	    IDes ides;
	    IDa ida;

	    ides = ifs;
	    ides.show(3);
	    ida = ifs;
	    ida.show(3);
	}

}
