using System.Collections;
using UnityEngine;

public class MainState : MonoBehaviour
{
    private IState _status;
    private float _speed;

	// Use this for initialization
	void Start () {
	    _status = new Run(100f);
	    StartCoroutine(TransitionState());
	}

    void Update()
    {
        _status.Move();
    }


    IEnumerator TransitionState()
    {
        yield return new WaitForSeconds(3f);
        _status = new Walk(50f);
    }

}
