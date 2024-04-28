using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnDamageParticleByRaycast : MonoBehaviour
{
    [SerializeField] private GameObject _particle;

    public void ReturnDamageParticleEffect(Vector3 point)
    {
        Instantiate(_particle, point, Quaternion.identity);
    }
}