using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public float speed;
    public Transform loadingBar;

    void Update()
    {
        if(loadingBar)
            transform.position = Vector3.MoveTowards(transform.position, loadingBar.position, speed);
    }
}
