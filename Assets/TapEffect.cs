using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapEffect : MonoBehaviour {

	[SerializeField] ParticleSystem _particleSystem;
	[SerializeField] Camera _camera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) {
			var pos = _camera.ScreenToWorldPoint(Input.mousePosition + _camera.transform.forward * 10);
			_particleSystem.transform.position = pos;
			_particleSystem.Emit(1);
		}
		
	}
}
