using UnityEngine;
using System.Collections;
using _3_Animation.Scripts;

public class ItemController : MonoBehaviour {

    [SerializeField] private int _healPoint = 20;
    [SerializeField] private LifeController _lifeScript;

    void OnCollisionEnter2D (Collision2D col)
    {
        //ユニティちゃんと衝突した時
        if (!col.gameObject.CompareTag("UnityChan")) return;
        //LifeUpメソッドを呼び出す　引数はhealPoint
        _lifeScript.LifeUp(_healPoint);
        //アイテムを削除する
        Destroy(gameObject);
    }
}    