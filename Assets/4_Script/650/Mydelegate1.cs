using UnityEngine;

delegate void delegate1();

public class Mydelegate1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        delegate1 d1 = new delegate1(show);
	    d1();
	}

    public static void show()
    {
        Debug.Log("called");
    }
}
