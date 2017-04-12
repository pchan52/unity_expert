using UnityEngine;

public class Property : MonoBehaviour
{
    private float h;

    public float hight
    {
        get { return h; }
        set
        {
            if (value <= 0)
            {
                Debug.Log("不正な値です。");
            }
            else
            {
                h = value;
            }
        }
    }
}
