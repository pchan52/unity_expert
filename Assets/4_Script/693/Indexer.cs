using UnityEngine;

public class Indexer : MonoBehaviour
{
    private string[] array;
    private int nMax;


    public Indexer(int i)
    {
        array = new string[i];
        nMax = i;
    }

    public string this[int n]
    {
        get
        {
            if (n < nMax)
                return array[n];
            else
                return "名無し";
        }
        set
        {
            if (n < nMax)
                array[n] = value;
        }
    }
}
