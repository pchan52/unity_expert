using UnityEngine;

public class TestOut : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    double a = 15.0;
	    double b = 2.5;
	    double c;

	    Square(a,b,out c);
	    Debug.Log(c);
	}

    private void Square(double x, double y, out double s)
    {
        s = x * y;
    }
}
