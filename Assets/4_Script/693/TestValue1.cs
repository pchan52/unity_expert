using UnityEngine;

public class TestValue1 : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    int[] a = {1, 2, 3};
	    for (int i = 0; i < a.Length; i++)
	    {
	        print(a[i]);
	    }
	    ChangeValue1(a);
	    for (int i = 0; i < a.Length; i++)
	    {
	        print(a[i]);
	    }
	}

    private void ChangeValue1(int[] a)
    {
        a = new int[] {2, 4, 8};
    }
}
