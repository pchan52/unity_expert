using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var dict = new Dictionary<int, string>();

	    dict.Add(2,"sakamoto");
	    dict.Add(1,"hirata");
	    dict.Add(5,"ikeda");
	    dict.Add(3,"takuma");
	    dict.Add(4,"ookubo");

	    Debug.Log(dict[5]);

	    //削除対象のキーを格納するList
	    var removeKeys = new List<int>();

	    foreach (var pair in dict)
	    {
	        if(pair.Value == "hirata") removeKeys.Add(pair.Key);
	    }

	    foreach (var key in removeKeys)
	    {
	        dict.Remove(key);
	    }

	    // DictionaryをList<KeyValuePair>に変換
	    List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>(dict);

	    list.Sort((x, y) => x.Key - y.Key);

	    foreach (var p in list)
	    {
	        Debug.Log(p.Key + "は" + p.Value + "さんです");
	    }

	    foreach (var p in dict)
	        Debug.Log(p.Key + "は" + p.Value + "さんです");
	}
}
