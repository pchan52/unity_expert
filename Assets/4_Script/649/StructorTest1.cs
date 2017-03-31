using UnityEngine;

public class StructorTest1 : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    Mystruct1.show();
	    Mystruct1.i = 20;
	    Mystruct1.show();
	}
}

struct Mystruct1
{
    public static int i = 10;

    public static void show()
    {
        Debug.Log(i);
    }

}
