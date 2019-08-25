using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataFactory : MonoBehaviour
{
    public GameObject dataPrefab;
    public Transform loadingBar;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(dataPrefab, transform);
            dataPrefab.GetComponent<Data>().loadingBar = loadingBar;
        }
    }
}
