using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Profiling;
using System.Linq;

public class Klass {
	int i;
	float j;

	public Klass(int i, float j) {
		this.i = i;
		this.j = j;
	}

	~Klass() {
		Debug.Log ("called destructor");
	}
}


public class MemoryTest : MonoBehaviour {
	
	void Start(){
		StartCoroutine (TestGC ());
	}

	IEnumerator TestGC(){
		GC.Collect ();
		GC.WaitForPendingFinalizers();
		GC.Collect ();

		long first = GC.GetTotalMemory (false);
		print ("first MakeArray : " + first.ToString("N0"));

		yield return new WaitForSeconds (1.0f);

		MakeArray ();

		yield return new WaitForSeconds (1.0f);


		GC.Collect ();
		GC.WaitForPendingFinalizers();
		GC.Collect ();

		long fin = GC.GetTotalMemory (false);
		print ("fin MakeArray : " + fin.ToString("N0"));
		yield break;
	}
		
	void MakeArray(){
//		//Klass[,] array2D = new Klass[100, 100]; //参照型
//		var array2D = new int[100, 100]; //値型
//			
//		for(var i = 0;i < 100; i++) {
//			for(var j=0; j < 100; j++) {
//				//array2D [i, j] = new Klass (1, 0.1f);
//				//array2D[i,j] = 0;
//			}
//		}


		var sample = new[]
		{
			new { X = 0, Y = 10, Z = new[]{ 1, 2, 3} },
			new { X = 1, Y = 11, Z = new[]{ 4, 5, 6} },
			new { X = 2, Y = 12, Z = new[]{ 7, 8, 9} },
			new { X = 3, Y = 13, Z = new[]{ 0, 1, 2} },
			new { X = 4, Y = 14, Z = new[]{ 3, 4, 5} },
		};

		var select_test =
			from p in sample
			select p.X;


		GC.Collect ();
		GC.WaitForPendingFinalizers();
		GC.Collect ();

		long middle = GC.GetTotalMemory (false);
		print ("middle MakeArray : " + middle.ToString("N0"));
	}

}
