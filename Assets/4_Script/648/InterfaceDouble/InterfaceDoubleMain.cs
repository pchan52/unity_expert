using UnityEngine;

public class InterfaceDoubleMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    InterfaceDouble ifd = new InterfaceDouble();
	    ifd.Show(2);
	    ifd.Show(3,4);
	}

}
