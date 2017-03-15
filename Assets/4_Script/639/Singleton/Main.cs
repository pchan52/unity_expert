using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public partial class Main : MonoBehaviour
{
    private SingletonSample _sample1;
    private SingletonSample _sample2;
    private SingletonSampleObject _sample3;
    private SingletonSampleObject _sample4;

    // Use this for initialization
	void Start () {
		_sample1 = SingletonSample.GetInstance;
	    _sample2 = SingletonSample.GetInstance;
	    _sample3 = SingletonSampleObject.GetInstance;
	    _sample4 = SingletonSampleObject.GetInstance;

	    if (_sample1 == _sample2)
	    {
	        Debug.Log("sample1 == sample2");
	    }

	    Debug.Log(_sample2.testNum);
	    _sample1.setNum(100);
	    Debug.Log(_sample2.testNum);

	    if (_sample3 == _sample4)
	    {
	        Debug.Log("sample3 == sample4");
	    }

	}
}
