using UnityEngine;

public class Enemy2 : MonoBehaviour, IEnemy
{

    private int Hp = 0;

    public Enemy2(int a)
    {
        Hp = a;
    }

    // Update is called once per frame
    public void Update () {
        if (Input.GetMouseButtonDown(0) && Hp > 0)
        {
            Hp -= 1;
            print("Enemy2 Hp : " + Hp);
        }

//        if (Hp < 0)
//        {
//            Hp = 0;
//        }

    }
}
