using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private GameObject obj;
    private List<IEnemy> enemies;
    private EnemyManager enemyManager;

	// Use this for initialization
	void Start () {
	    Initialize();

	    enemyManager = new EnemyManager(enemies);

	}
	
	// Update is called once per frame
	void Update () {
	    enemyManager.Update();
	}

    void Initialize()
    {
        enemies = new List<IEnemy>();
        enemies.Add(new Enemy1());
        enemies.Add(new Enemy2(10));
        enemies.Add(new Enemy3(8, obj));
    }
}
