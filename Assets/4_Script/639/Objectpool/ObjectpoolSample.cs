using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectpoolSample : MonoBehaviour {

    //singleton
    //   public static ObjectPoller poller;
    public GameObject pollObject;
    public int polledAmount = 20 ;
    public List<GameObject> pollList;
    public bool isAllowIncrease = true;

    // Use this for initialization
    void Start () {
        pollList = new List<GameObject>();
        //setting for pollList object
        for (int i = 0; i < polledAmount; i++) {
            GameObject gameObject = (GameObject)Instantiate(pollObject);
            gameObject.transform.position = new Vector3(-10f + i,0,0);
            gameObject.SetActive(false);
            pollList.Add(gameObject);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            getPollObject();
        }

    }

    public GameObject getPollObject() {
        for (int i = 0; i < pollList.Count; i++) {
            if (!pollList[i].activeInHierarchy) {
                pollList[i].SetActive(true);
                Debug.Log(i);
                return pollList[i];
            }
        }
        if (isAllowIncrease) {
            GameObject gameObject = (GameObject)Instantiate(pollObject);
            pollList.Add(gameObject);
            return gameObject;
        }
        return null;
    }
}
