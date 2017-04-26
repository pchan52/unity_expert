using UnityEngine;
using System;

public class GenericTest : MonoBehaviour {

	// Use this for initialization
	void Start () {

		var answer_int = Max<int>(3,5); 
		print (answer_int);

		var answer_float = Max<float> (3.5f, 6.5f);
		print (answer_float);

		var mystack1 = new Mystack<int> (5);
		mystack1.Push (1);
		mystack1.Push (2);
		mystack1.Push (3);
		mystack1.ShowStack ();
		mystack1.Pop ();
		mystack1.ShowStack ();

	    var mystack2 = new Mystack<float>(5);
	    mystack2.Push(1.2f);
	    mystack2.Push(2.4f);
	    mystack2.Push(3.6f);
	    mystack2.ShowStack();
	    mystack2.Pop();
	    mystack2.ShowStack();
	}


	private int Max(int x, int y){
		if(x > y){
			return x;
		}else{
			return y;
		}
	}

	private T Max<T>(T x , T y)
		where T : IComparable
	{
		if (x != null && x.CompareTo(y) > 0) {
			return x;
		} else {
			return y;
		}
	}
}
