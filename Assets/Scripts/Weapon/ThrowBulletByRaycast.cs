using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBulletByRaycast : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private RaycastWeaponAttack _raycastWeaponAttack;
    [SerializeField] private Transform _spawnPosition;

    private void OnEnable()
    {
        _raycastWeaponAttack.Attacked += OnAttacked;
    }

    private void OnDisable()
    {
        _raycastWeaponAttack.Attacked -= OnAttacked;
    }

    private void OnAttacked()
    {
        Bullet bullet = Instantiate(_bullet, _spawnPosition.position, Quaternion.identity);
        bullet.TargetPoint = _raycastWeaponAttack.Raycast.origin +
                             _raycastWeaponAttack.Raycast.direction * _raycastWeaponAttack.Distance;
    }
}