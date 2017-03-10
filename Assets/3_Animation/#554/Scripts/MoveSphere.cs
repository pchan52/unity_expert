using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveSphere : MonoBehaviour {

	// Use this for initialization
    void Start()
    {
     //   transform.DOLocalPath(new Vector3[] {new Vector3(3, 3), Vector3.zero, new Vector3(-3, 2)}, 3f, PathType.CatmullRom);

       //transform.DOPunchPosition(new Vector3(-5, 0), 2f);

        transform.DOLocalPath (new Vector3[]{ new Vector3 (3f, 3f), Vector3.zero, new Vector3 (-3f, 2f) }, 2f, PathType.CatmullRom);
    }

    // Update is called once per frame
	void Update ()
	{

	  //  transform.DOLocalMoveX(-3f, 2f);

	}

}
