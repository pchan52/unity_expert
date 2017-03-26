using UnityEngine;

public class TestParams : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    ShowMember("平田","坂本","齊藤");
	    ShowMember("平田","坂本","齊藤","池田");
	    ShowMember("平田","坂本","齊藤","池田","大久保");
	}

    public void ShowMember(params string[] name)
    {
        if (name.Length == 0)
        {
            return;
        }
        foreach (var t in name)
        {
            Debug.Log(t);
        }
    }
}
