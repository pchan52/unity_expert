using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Test2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var list = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 8, 1, 0, 4 };
		var list1 = new ArrayList{1, 2L, 3, 4m, 5, 6D, 7, 8f};

		var count = list.Count(n => n == 0);
		print ("LINQ count : " + count);

		var exist = list.Any (n => n > 10);
		print ("LINQ exist : " + exist);

		var all = list.All (n => n >= 0);
		print ("LINQ all : " + all);

		var intList = list1.OfType<int>();
		foreach (var p in intList)
			print (p);

		var first = list.First (n => n < 3);
		print ("LINQ first : " + first);

		var firstordefault = list.FirstOrDefault (n => n > 9);
		print ("LINQ firstordefault : " + firstordefault);

		var max = list.Max (n => n);
		print ("LINQ max : " + max);

		var min = list.Min (n => n);
		print ("LINQ min : " + min);

		var sum = list.Sum (n => n * n);
		print ("LINQ sum : " + sum);

		var ave = list.Average (n => n);
		print ("LINQ average : " + ave);

		var sort = list.OrderBy (n => -n);
		foreach (var n in sort)
			print (n);
	}
}
