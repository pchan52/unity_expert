using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GenericTest : MonoBehaviour {

	// Use this for initialization
	void Start () {

		var answer_int = Max<int>(3,5); 
		print (answer_int);

		var answer_double = Max<double> (3.5d, 6.5d);
		print (answer_double);
	}

		
	int Max(int x, int y){
		if(x > y){
			return x;
		}else{
			return y;
		}
	}

	private T Max<T>(T x , T y)
		where T : IComparable
	{
		if (x.CompareTo(y) > 0) {
			return x;
		} else {
			return y;
		}
	}
}
