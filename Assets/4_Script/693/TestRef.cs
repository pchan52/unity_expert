using UnityEngine;

public class TestRef : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    int a = 100;
	    Debug.Log(a);
	    ChangeValue(ref a);
	    Debug.Log(a);
	}

    private void ChangeValue(ref int a)
    {
        a = 10;
    }
}
