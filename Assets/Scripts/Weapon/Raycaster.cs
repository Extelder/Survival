using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Raycaster : MonoBehaviour
{
    [field: SerializeField] public Transform Camera { get; private set; }
    [field: SerializeField] public float Distance { get; private set; }

    public Ray ThrowRaycast(out RaycastHit hit, Vector3 spread)
    {
        Ray ray = new Ray(Camera.position, Camera.forward + spread);
        Physics.Raycast(ray.origin, ray.direction, out hit, Distance);
        return ray;
    }
}