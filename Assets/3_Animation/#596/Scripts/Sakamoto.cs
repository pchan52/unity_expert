﻿using UnityEngine;

namespace _3_Animation.Scripts
{
    public class Sakamoto : MonoBehaviour {
        private new Rigidbody2D _rigidbody2D;
        [SerializeField] private int _speed = -3;
        [SerializeField] private GameObject _explosion;
        [SerializeField] private GameObject _explosionPoint;

        private void Start () {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update () {
            _rigidbody2D.velocity = new Vector2 (_speed, _rigidbody2D.velocity.y);
        }

        private void OnTriggerEnter2D (Collider2D col)
        {
            if (!col.CompareTag("Bullet")) return;
            Instantiate (_explosion, _explosionPoint.transform.position, _explosionPoint.transform.rotation);
            Destroy (gameObject);

        }
    }
}