using UnityEngine;

public class OverLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log(Add(1,2));
	    Debug.Log(Add(1.5,2.3));
	    Debug.Log(Add("池田","光"));
	}

    private int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }

    private double Add(double a, double b)
    {
        double c = a + b;
        return c;
    }

    private string Add(string a, string b)
    {
        string c = a + b;
        return c;
    }
}
