using UnityEngine;

public class Throw : MonoBehaviour {

    private int _hp;

    void Start ()
    {
        _hp = 11;
        if (_hp > 10)
        {
            //  throwで例外を投げて、エラー状況をArgumentOutOfRangeExceptionとした
            throw new System.ArgumentOutOfRangeException ("HPが大きすぎます");
            Debug.Log (_hp);
        }
    }
}
