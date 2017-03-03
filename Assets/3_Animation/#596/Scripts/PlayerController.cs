using UnityEngine;

namespace _3_Animation.Scripts
{
    public class PlayerController : MonoBehaviour {

        [SerializeField] private float _speed = 4f;
        private Rigidbody2D _rigidbody2D;
        private Animator _anim;
        [SerializeField] float _jumpPower = 700; //ジャンプ力
        [SerializeField] private LayerMask _groundLayer; //Linecastで判定するLayer
        [SerializeField] private bool _isGrounded; //着地判定

        private void Start () {
            _anim = GetComponent<Animator>();
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update ()
        {
            //Linecastでユニティちゃんの足元に地面があるか判定
            _isGrounded = Physics2D.Linecast (
                transform.position + transform.up * 1,
                transform.position - transform.up * 1.5f,
                _groundLayer);
            //スペースキーを押し、
            if (Input.GetKeyDown ("space")) {
                //着地していた時、
                if (_isGrounded) {
                    //Dashアニメーションを止めて、Jumpアニメーションを実行
                    _anim.SetBool("Dash", false);
                    _anim.SetTrigger("Jump");
                    //着地判定をfalse
                    _isGrounded = false;
                    //AddForceにて上方向へ力を加える
                    _rigidbody2D.AddForce (Vector2.up * _jumpPower);
                }
            }
            //上下への移動速度を取得
            var velY = _rigidbody2D.velocity.y;
            //移動速度が0.1より大きければ上昇
            var isJumping = velY > 0.1f ? true:false;
            //移動速度が-0.1より小さければ下降
            var isFalling = velY < -0.1f ? true:false;
            //結果をアニメータービューの変数へ反映する
            _anim.SetBool("isJumping",isJumping);
            _anim.SetBool("isFalling",isFalling);
        }

        private void FixedUpdate ()
        {
            var x = Input.GetAxisRaw ("Horizontal");
            if (x != 0) {
                _rigidbody2D.velocity = new Vector2 (x * _speed, _rigidbody2D.velocity.y);
                Vector2 temp = transform.localScale;
                temp.x = x;
                transform.localScale = temp;
                _anim.SetBool ("Dash", true);

            } else {
                _rigidbody2D.velocity = new Vector2 (0, _rigidbody2D.velocity.y);
                _anim.SetBool ("Dash", false);
            }
        }
    }
}