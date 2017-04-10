using UnityEngine;

public class Enemy3 : MonoBehaviour, IEnemy
{

    private int Hp = 0;
    private GameObject obj;

    public Enemy3(int a, GameObject obj)
    {
        Hp = a;
        this.obj = obj;
    }

    // Update is called once per frame
    public void Update () {
        if (Input.GetMouseButtonDown(0) && Hp > 0)
        {
            Hp -= 1;
            print("Enemy3 Hp : " + Hp);
        }

        if (Hp == 0)
        {
            Hp -= 1;
            Instantiate(obj);
        }

    }
}
