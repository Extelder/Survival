using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCursor : MonoBehaviour
{
    private void Awake()
    {
        Lock();
    }

    public void Lock()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void UnLock()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
