using System.Collections.Generic;
using UnityEngine;
using System;

public class Finally : MonoBehaviour {


    private int _hp;

    void Start ()
    {
        var list = new List<string> ();
        try
        {
            Debug.Log(list[0]);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Debug.Log(e.Message);
        }
        finally
        {
            Debug.Log("called finally");
        }
    }
}
