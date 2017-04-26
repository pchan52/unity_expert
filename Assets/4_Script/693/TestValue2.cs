using UnityEngine;

public class TestValue2 : MonoBehaviour {

    // Use this for initialization
    void Start ()
    {
        int[] a = {1, 2, 3};
        for (int i = 0; i < a.Length; i++)
        {
            print(a[i]);
        }
        ChangeValue2(a);
        for (int i = 0; i < a.Length; i++)
        {
            print(a[i]);
        }
    }

    private void ChangeValue2(int[] a)
    {
        a[0] = 5;
    }
}
