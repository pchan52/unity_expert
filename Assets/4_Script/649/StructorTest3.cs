using UnityEngine;

public class StructorTest3 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        MyData md = new MyData();
        md.x = 10;
        md.y = 20;

        ChangeData cd = new ChangeData();
        cd.change(md);
        print(md.x);
        print(md.y);

        cd.change(ref md);
        print(md.x);
        print(md.y);


        MyData m;
        m.x = 10;
        m.y = 20;
        cd.change(ref m);
        print(m.x);
        print(m.y);

        MyDataClass mdc = new MyDataClass();
        mdc.x = 10;
        mdc.y = 20;
        cd.change(mdc);
        print(mdc.x);
        print(mdc.y);
    }
}
