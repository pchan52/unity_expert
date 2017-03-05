using UnityEngine;

namespace _3_Animation.Scripts
{
    public class EnemyController : MonoBehaviour {
        private new Rigidbody2D _rigidbody2D;
        [SerializeField] private int _speed = -3;
        [SerializeField] private GameObject _explosion;
        [SerializeField] private int _attackPoint = 10;
        [SerializeField] private LifeController _lifeController;

        private void Start () {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update () {
            _rigidbody2D.velocity = new Vector2 (_speed, _rigidbody2D.velocity.y);
        }

        private void OnTriggerEnter2D (Collider2D col)
        {
            if (!col.CompareTag("Bullet")) return;
            Instantiate (_explosion, transform.position, transform.rotation);
            Destroy (gameObject);

        }

        void OnCollisionEnter2D (Collision2D col)
        {
            //UnityChanとぶつかった時
            if (col.gameObject.CompareTag("UnityChan")) {
                //LifeScriptのLifeDownメソッドを実行
                _lifeController.LifeDown(_attackPoint);
            }
        }
    }
}