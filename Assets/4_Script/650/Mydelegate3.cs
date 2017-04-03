using UnityEngine;

delegate void delegate3();

public class Mydelegate3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    Mydelegate3sub md3s = new Mydelegate3sub();
	    delegate3 d3 = new delegate3(md3s.show1);

	    d3();

	    d3 += new delegate3(md3s.show2);

	    d3();

	    d3 += new delegate3(md3s.show3);

	    d3();

	    d3 -= new delegate3(md3s.show2);

	    d3();
	}
}
