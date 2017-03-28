using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugarray : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[][] jug = {
			new[] { 1 },
			new[] { 2, 3, 4 }
		};	
		for (var i = 0; i < jug.Length; i++) {
			print (jug [i].Length);
			for (var j = 0; j < jug [i].Length; j++) {
				print (jug [i] [j]);
			}
		}
	}
}
