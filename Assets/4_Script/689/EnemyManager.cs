using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private List<IEnemy> _enemies;

    public EnemyManager(List<IEnemy> enemies)
    {
        _enemies = enemies;
    }

    public void Update()
    {
        foreach (var enemy in _enemies)
        {
            enemy.Update();
        }
    }
}
