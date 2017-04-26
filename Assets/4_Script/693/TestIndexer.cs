using UnityEngine;

public class TestIndexer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    Indexer indexer = new Indexer(5);
	    indexer[0] = "平田";
	    indexer[1] = "坂本";
	    indexer[2] = "齊藤";
	    indexer[3] = "池田";
	    indexer[4] = "大久保";

	    for (var i = 0; i < 5; i++)
	    {
	        Debug.Log(indexer[i]);
	    }

	    indexer[10] = "近藤";
	    Debug.Log(indexer[10]);
	}
}
