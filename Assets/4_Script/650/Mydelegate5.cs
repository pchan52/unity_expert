using UnityEngine;

delegate void delegate5();

delegate int delegate6(int x, int y);

public class Mydelegate5 : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
//	    delegate5 d5 = () => { show(); };
//	    delegate5 d5 = () => {print("called");};
	    delegate6 d6 = (int x, int y) => {return x+y;};
//	    d5();
	    print(d6(2, 4));
	}


    public static void show()
    {
        print("called");
    }

}
