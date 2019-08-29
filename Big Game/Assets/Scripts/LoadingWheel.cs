using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingWheel : MonoBehaviour
{
    public SoundManager soundManager;

    public int ammo;

    public int ammoSize;

    private void Start()
    {
        ammo = ammoSize;
    }

    void Update()
    {
        Vector3 position = Input.mousePosition;
        position.z = 1;
        position = Camera.main.ScreenToWorldPoint(position);
        transform.position = position;

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }

        if (Input.GetMouseButtonDown(1))
        {
            Reload();
        }
    }

    void Fire()
    {
        soundManager.Fire();
        ammo--;
    }

    void Reload()
    {
        soundManager.Reload();
        ammo = ammoSize;
    }
}
