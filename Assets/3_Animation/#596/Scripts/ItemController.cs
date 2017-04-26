using UnityEngine;
using System.Collections;
using _3_Animation.Scripts;

public class ItemController : MonoBehaviour {

    [SerializeField] private int _healPoint = 20;
    private LifeController _lifeScript;


    private void Start ()
    {
        //HPタグの付いているオブジェクトのLifeScriptを取得
        _lifeScript = GameObject.FindGameObjectWithTag("HP").GetComponent<LifeController>();
    }

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