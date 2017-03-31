using UnityEngine;

public class ChangeData : MonoBehaviour {


    public void change(ref MyData md)
    {
        int temp;
        temp = md.x;
        md.x = md.y;
        md.y = temp;
    }

    public void change(MyData md)
    {
        int temp;
        temp = md.x;
        md.x = md.y;
        md.y = temp;
    }

    public void change(MyDataClass md)
    {
        int temp;
        temp = md.x;
        md.x = md.y;
        md.y = temp;
    }
}


