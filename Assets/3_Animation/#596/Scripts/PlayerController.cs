using UnityEngine;

namespace _3_Animation.Scripts
{
    public class PlayerController : MonoBehaviour {

        public float Speed; //歩くスピード
        private new Rigidbody2D _rigidbody2D;
        private Animator _anim;

        void Start () {
            //各コンポーネントをキャッシュしておく
            _anim = GetComponent<Animator>();
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate ()
        {
            //左キー: -1、右キー: 1
            var x = Input.GetAxisRaw ("Horizontal");
            //左か右を入力したら
            if (x != 0) {
                //入力方向へ移動
                _rigidbody2D.velocity = new Vector2 (x * Speed, _rigidbody2D.velocity.y);
                //localScale.xを-1にすると画像が反転する
                Vector2 temp = transform.localScale;
                temp.x = x;
                transform.localScale = temp;
                //Wait→Dash
                _anim.SetBool ("Dash", true);
                //左も右も入力していなかったら
            } else {
                //横移動の速度を0にしてピタッと止まるようにする
                _rigidbody2D.velocity = new Vector2 (0, _rigidbody2D.velocity.y);
                //Dash→Wait
                _anim.SetBool ("Dash", false);
            }
        }
    }
}