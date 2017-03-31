using UnityEngine;

public class StructorTest2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Mystruct2 ms2 = new Mystruct2();
	    ms2.show();
	    ms2.xprop = 20;
	    ms2.show();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

struct Mystruct2 : IStructorInterface
{
    private int x;

    public void show()
    {
        Debug.Log(x);
    }

    public int xprop
    {
        get { return x; }
        set { x = value; }
    }

}
