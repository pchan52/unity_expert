using System;
using UnityEngine;

public class CheckedOverFlow : MonoBehaviour
{

    private int x, y, z;

	// Use this for initialization
	void Start ()
	{
	    try
	    {
	        checked
	        {
	            x = int.MaxValue;
	            y = 1;
	            z = x + y;

	            Debug.Log(x);
	            Debug.Log(z);
	        }
	    }
	    catch (OverflowException e)
	    {
	        Debug.Log(e.Message);
	    }
	}

}
