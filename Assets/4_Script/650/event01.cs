using UnityEngine;

public class event01 : MonoBehaviour {

    float time = 0;
    MyClass mc = new MyClass();
    MyEventClass myevent = new MyEventClass();

    // Use this for initialization
	void Start () {
	    myevent.eventname += new Mydelegate(mc.show);
	}

    void Update()
    {
        time += Time.deltaTime;
        if (time > 10)
        {
            myevent.OnEventname();
            time = 0;
        }
    }

}
