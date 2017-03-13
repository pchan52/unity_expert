using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyweightTestUnused : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        //悪い例 それぞれでインスタンスを作っている
        var instance_i = new Letter("i");
        ShowLetter(instance_i);
        var instance_a = new Letter("a");
        ShowLetter(instance_a);
        var instance_m = new Letter("m");
        ShowLetter(instance_m);
        var instance_a_1 = new Letter("a");
        ShowLetter(instance_a_1);
        var instance_m_1 = new Letter("m");
        ShowLetter(instance_m_1);
        var instance_a_2 = new Letter("a");
        ShowLetter(instance_a_2);
        var instance_n = new Letter("n");
        ShowLetter(instance_n);

        //まだまし
//        var instance_i = new Letter("i");
//        ShowLetter(instance_i);
//        var instance_a = new Letter("a");
//        ShowLetter(instance_a);
//        var instance_m = new Letter("m");
//        ShowLetter(instance_m);
//        ShowLetter(instance_a);
//        ShowLetter(instance_m);
//        ShowLetter(instance_a);
//        var instance_n = new Letter("n");
//        ShowLetter(instance_n);

    }

    private void ShowLetter(Letter letter)
    {
        Debug.Log(letter.Singleletter);
    }

}
