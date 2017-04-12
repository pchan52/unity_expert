using UnityEngine;

public class CompareSample : MonoBehaviour {

    private IComparator _comparator = null;
    private int resultheight = 0;
    private int resultage = 0;


    void Start()
    {
        Human h1 = new Human("aaa", 170, 60, 20);
        Human h2 = new Human("bbb", 175, 55, 20);
        _comparator = new AgeComparator();
        resultage = compare(h1, h2);

        _comparator = new HeightComparator();
        resultheight = compare(h1, h2);

        print("age :" + resultage);
        print("height :" + resultheight);
    }

    public CompareSample(IComparator comparator){
        this._comparator = comparator;
    }

    public int compare(Human h1,Human h2){
        return _comparator.compare(h1,h2);
    }
}
