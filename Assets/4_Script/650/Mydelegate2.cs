using UnityEngine;

delegate void mydelegate(int a);

public class Mydelegate2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Mydelegate2sub md2s = new Mydelegate2sub();
	    md2s.show(5);

	    mydelegate md = new mydelegate(md2s.show);
	    md(10);
	}

}
