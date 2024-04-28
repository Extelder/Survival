using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour
{
    [field: SerializeField] private Health _health;
    [field: SerializeField] private ReturnDamageParticleByRaycast _returnDamageParticleByRaycast;

    public virtual void Hit(float damage, RaycastHit hit)
    {
        _returnDamageParticleByRaycast?.ReturnDamageParticleEffect(hit.point);
        _health?.TakeDamage(damage);
        Debug.Log("Hited");
    }
    public virtual void Hit(float damage)
    {
        _health?.TakeDamage(damage);
        Debug.Log("Hited");
    }
}
