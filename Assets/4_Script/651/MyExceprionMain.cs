using UnityEngine;

public class MyExceprionMain : MonoBehaviour
{

    [SerializeField] private int x;

	// Use this for initialization
	void Start () {
	    try
	    {
	        if (x == 0)
	        {
	            throw new MyException();
	        }
	        Debug.Log(10 / x);
	    }
	    catch (MyException e)
	    {
	        Debug.Log(e.Message);
	        Debug.Log(e.ToString());
	    }
	}

}
