using UnityEngine;

delegate void delegate4(int a);

public class Mydelegate4 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	    //いままで
	    Mydelegate4sub md4s = new Mydelegate4sub();
	    delegate4 d4 = new delegate4(md4s.Show);
	    d4(5);

	    //匿名メソッド
	    delegate4 d4s = delegate(int a)
	    {
	        if (a > 10)
	        {
	            print("10より大きいです");
	        }
	        else
	        {
	            print("10以下です");
	        }

	    };

	    d4s(10);
	}

}
