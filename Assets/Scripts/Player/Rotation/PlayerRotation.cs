using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] private Transform _camera;

    private void Update()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, _camera.eulerAngles.y, transform.eulerAngles.z);
    }
}
