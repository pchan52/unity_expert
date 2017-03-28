using UnityEngine;

public class InterfaceDouble : MonoBehaviour,IFirst, ISecond {

    public void Show(int x)
    {
        print(x);
    }

    public void Show(int x, int y)
    {
        print("x = " + x + ", y = " + y);
    }
}


