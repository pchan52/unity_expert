using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;  //クエリ式を使えるように

public class Test1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var sample = new[]
		{
			new { X = 0, Y = 10, Z = new[]{ 1, 2, 3} },
			new { X = 1, Y = 11, Z = new[]{ 4, 5, 6} },
			new { X = 2, Y = 12, Z = new[]{ 7, 8, 9} },
			new { X = 3, Y = 13, Z = new[]{ 0, 1, 2} },
			new { X = 4, Y = 14, Z = new[]{ 3, 4, 5} },
		};

		var sample1 = new[] {
			new { X = 0, W = 1 },
			new { X = 0, W = 2 },
			new { X = 1, W = 3 },
			new { X = 1, W = 4 },
		};

//		var select_test =
//			from p in sample
//			select p.X;
//		foreach (var p in select_test)
//			print (p);

		var select_test_lambda = sample
			.Select (p => p.X);
		foreach (var p in select_test_lambda)
			print (p);

//		var where_test = 
//			from p in sample
//			where p.X > 2		
//			select p;
//		foreach (var p in where_test)
//			print (p);

		var where_test_lambda = sample
			.Where (p => p.X > 2)
			.Select (p => p);
		foreach (var p in where_test_lambda)
			print (p);

//		var group_test =
//			from p in sample1
//			group p.W by p.X;
//
//		foreach (var p in group_test)
//		{
//			print("p : " + p.Key);
//			foreach (var q in p)
//				print(q);
//		}

		var group_test_lambda = sample1
			.GroupBy (p => p.X, p => p.W);
		foreach (var p in group_test_lambda)
		{
			print("p : " + p.Key);
			foreach (var q in p)
				print(q);
		}

//		var into_test =
//			from p in sample
//			select p.X into x
//			where x > 2
//			select x;
//		foreach (var p in into_test)
//			print (p);

		var into_test_lambda = sample
			.Select(p => p.X)
			.Where(x => x > 2);
		foreach (var p in into_test_lambda)
			print (p);

//		var orderby_test =
//			from p in sample
//			orderby p.X descending
//			select p;
//
//		foreach (var p in orderby_test)
//			print(p);

		var orderby_test_lambda = sample
			.OrderByDescending (p => p.X);
		foreach (var p in orderby_test_lambda)
			print (p);


//		var join_test = 
//			from p in sample
//			join q in sample1 on p.X equals q.X
//			select new { p.X, p.Y, q.W };
//		foreach (var p in join_test)
//			print (p);

		var join_test_lambda = sample
			.Join(sample1, p => p.X, q => q.X,
				(p, q)=> new { p.X, p.Y, q.W });
		foreach (var p in join_test_lambda)
			print (p);

//		var let_test =
//			from p in sample
//			let sumZ = p.Z.Sum()
//			select new { p.X, sumZ };
//
//		foreach (var p in let_test)
//			print (p);

		var let_test_lambda = sample
			.Select(p => new { p, SumZ = p.Z.Sum() })
			.Select(p2 => new { p2.p.X, p2.SumZ });
		foreach (var p in let_test_lambda)
			print (p);

//		var queries_expression = 
//			from p in sample
//			where p.X < 10
//			select p.X;
//
//		var lambda_expression = sample.Where (p => p.X < 10).Select (p => p.X);
//
//		foreach (var p in queries_expression)
//			print("queries_expression : " + p);
//
//		foreach (var p in lambda_expression)
//			print("lambda_expression : " + p);


	}
}
