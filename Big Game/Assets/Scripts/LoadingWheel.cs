using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingWheel : MonoBehaviour
{
    void Update()
    {
        Vector3 position = Input.mousePosition;
        position.z = 1;
        position = Camera.main.ScreenToWorldPoint(position);
        transform.position = position;
    }
}
