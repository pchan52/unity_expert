using UnityEngine;

namespace _3_Animation.Scripts
{
    public class BulletController: MonoBehaviour {

        private GameObject _player;
        private const int Speed = 10;

        private void Start () {
            //ユニティちゃんオブジェクトを取得
            _player = GameObject.FindWithTag("UnityChan");
            //rigidbody2Dコンポーネントを取得
            var rigidbody2D = GetComponent<Rigidbody2D>();
            //ユニティちゃんの向いている向きに弾を飛ばす
            rigidbody2D.velocity = new Vector2 (Speed * _player.transform.localScale.x, rigidbody2D.velocity.y);
            //画像の向きをユニティちゃんに合わせる
            Vector2 temp = transform.localScale;
            temp.x = _player.transform.localScale.x;
            transform.localScale = temp;
            //5秒後に消滅
            Destroy(gameObject, 1f);
        }

        private void OnTriggerEnter2D (Collider2D col)
        {
            if (col.gameObject.CompareTag("Enemy")) {
                Destroy(gameObject);
            }
        }
    }
}