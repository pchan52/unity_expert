using UnityEngine;

public delegate void Mydelegate();

public class MyEventClass : MonoBehaviour
{

    public event Mydelegate eventname;

    public void OnEventname()
    {
        if (eventname != null)
        {
            eventname();
        }
    }
}
