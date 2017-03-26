using UnityEngine;

public class TestProperty : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    Property property = new Property();
	    property.hight = -3;
	    property.hight = 170;
	    Debug.Log(property.hight);
	}

}
