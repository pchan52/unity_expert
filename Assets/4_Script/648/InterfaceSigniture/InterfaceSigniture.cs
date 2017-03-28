using UnityEngine;

public class InterfaceSigniture : MonoBehaviour, IDa, IDes {

    void IDa.show(int a)
    {
        print("IDaが実行されました。 " + a);
    }

    void IDes.show(int a)
    {
        print("IDesが実行されました。 " + a);
    }
}
