using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheats : MonoBehaviour
{
    public LoadingBar loadingBar;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            loadingBar.completeAmount += .1f;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            loadingBar.completeAmount -= .1f;
        }
    }
}
