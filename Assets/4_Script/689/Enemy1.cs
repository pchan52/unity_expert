using UnityEngine;

public class Enemy1 : MonoBehaviour, IEnemy
{

    private int Hp = 0;

    public Enemy1()
    {
        Hp = 5;
    }

    // Update is called once per frame
	public void Update () {
	    if (Input.GetMouseButtonDown(0) && Hp > 0)
	    {
	        Hp -= 1;
	        print("Enemy1 Hp : " + Hp);
	    }
	}
}
