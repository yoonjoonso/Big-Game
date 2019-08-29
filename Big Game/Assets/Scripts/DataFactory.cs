using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataFactory : MonoBehaviour
{
    public GameObject dataPrefab;
    public Transform loadingBar;

    public float enemyIntensity; // used for sound

    private IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            Instantiate(dataPrefab, transform);
            dataPrefab.GetComponent<Data>().loadingBar = loadingBar;
            yield return new WaitForSeconds(1);
        }
    }

    private void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }
}
