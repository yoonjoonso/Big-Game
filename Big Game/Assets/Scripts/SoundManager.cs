using System;
using System.Collections;
using System.Collections.Generic;

using FMODUnity;

using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public DataFactory dataFactory;

    public LoadingBar loadingBar;

    public StudioEventEmitter eventEmitter;

    public void Fire()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Fire");
    }

    public void Reload()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Reload");
    }

    private void Update()
    {
        eventEmitter.SetParameter("Intensity", dataFactory.enemyIntensity);
        eventEmitter.SetParameter("Progress", loadingBar.completeAmount);
    }
}
