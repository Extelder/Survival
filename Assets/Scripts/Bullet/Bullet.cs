using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject _damageParticle;
    [SerializeField] private float _speed;
    [field: SerializeField] public Vector3 TargetPoint { get; set; }

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        transform.LookAt(TargetPoint);
        _rigidbody.AddForce(transform.forward * _speed);
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.TryGetComponent<HitBox>(out HitBox hitBox))
        {
            Instantiate(_damageParticle, transform.position, Quaternion.identity);
            hitBox.Hit(10f);
        }

        Destroy(gameObject);
    }
}