using UnityEngine;

public class TestValue : MonoBehaviour {


	void Start ()
	{
	    int a = 100;
	    Debug.Log(a);
	    ChangeValue(a);
	    Debug.Log(a);
	}

    private void ChangeValue(int a)
    {
        a = 10;
    }

}
