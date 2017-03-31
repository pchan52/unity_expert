using UnityEngine;

public class StructorTest : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    Mystruct ms;
	    ms.x = 10;
	    ms.show();
	}

}

struct Mystruct
{
    public int x ;

    public void show()
    {
        Debug.Log(x);
    }
}