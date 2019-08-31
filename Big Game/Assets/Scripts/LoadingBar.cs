using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingBar : MonoBehaviour
{
    public float completeAmount; // goes from 0 - 1
    public LoadingText loadingText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        loadingText.UpdateText(completeAmount);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //print("triggered by: " + other);
        if (other.CompareTag("Data"))
        {
            Destroy(other.gameObject);
        }
    }
}
