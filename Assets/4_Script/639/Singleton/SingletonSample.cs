using System;
using UnityEngine;

public class SingletonSample {

	private static SingletonSample _singleton = new SingletonSample();

    private SingletonSample()
    {

        Debug.Log("Create SingletonSample instance.");

    }

    public static SingletonSample GetInstance
    {
        get{
            if (_singleton == null) _singleton = new SingletonSample();

            return _singleton;
        }
    }

    public int testNum = 10;

    public void setNum(int num)
    {
        testNum = num;
    }
}
