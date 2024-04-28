using System;
using System.Collections;
using System.Collections.Generic;
using KrisDevelopment.EnvSpawn;
using UnityEngine;

public class EnviroGenerateor : MonoBehaviour
{
    private void Start()
    {
        EnviroSpawn_CS.MassInstantiateNew();
    }
}
