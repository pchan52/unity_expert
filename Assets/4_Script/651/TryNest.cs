using System;
using UnityEngine;

public class TryNest : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{

	    int x = 10;
	    int y = 0;

	    try
	    {
	        try
	        {
	            Debug.Log(x / y);
	        }
	        catch (IndexOutOfRangeException i)
	        {
	            Debug.Log(i.Message);
	        }
	    }
	    catch (DivideByZeroException d)
	    {
	        Debug.Log(d.Message);
	    }
	}

}
