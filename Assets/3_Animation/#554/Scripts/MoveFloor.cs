using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveFloor : MonoBehaviour
{

    [SerializeField] private Vector3 hPos1;
    [SerializeField] private Vector3 hPos2;
    [SerializeField] private Vector3 hPos3;
    [SerializeField] private Vector3 vPos1;
    [SerializeField] private Vector3 vPos2;
    [SerializeField] private Vector3 vPos3;
    [SerializeField] private float _time;

    void Start()
    {
        transform.DOLocalPath(new Vector3[] {vPos1, vPos2, vPos3}, _time, PathType.CatmullRom);

    }


    void Update () {

	    if (Input.GetKeyDown(KeyCode.A))
	    {
	        MoveHorizontal();
	    }

	    if (Input.GetKeyDown(KeyCode.B))
	    {
	        MoveVertical();
	    }

	}

    void MoveVertical()
    {
        transform.DOLocalPath(new Vector3[] {vPos1, vPos2, vPos3}, _time, PathType.CatmullRom);
    }

    void MoveHorizontal()
    {
        transform.DOLocalPath(new Vector3[] {hPos1,hPos2,hPos3 }, _time, PathType.CatmullRom);
    }
}
