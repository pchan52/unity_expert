using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float _activeTime = 0;
	
	// Update is called once per frame
	void Update () {
	    if (gameObject.activeInHierarchy)
	    {
	        _activeTime += Time.deltaTime;
	    }

	    if (_activeTime > 1.0f)
	    {
	        gameObject.SetActive(false);
	        _activeTime = 0;
	    }
	}
}
