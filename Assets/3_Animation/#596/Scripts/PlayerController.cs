using UnityEngine;

namespace _3_Animation.Scripts
{
    public class PlayerController : MonoBehaviour {

        public float Speed = 4f;
        private new Rigidbody2D _rigidbody2D;
        private Animator _anim;

        private void Start () {
            _anim = GetComponent<Animator>();
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate ()
        {
            var x = Input.GetAxisRaw ("Horizontal");
            if (x != 0) {
                _rigidbody2D.velocity = new Vector2 (x * Speed, _rigidbody2D.velocity.y);
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