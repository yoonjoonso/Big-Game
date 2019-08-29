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

    private void Update()
    {
        eventEmitter.SetParameter("Intensity", dataFactory.enemyIntensity);
        eventEmitter.SetParameter("Progress", loadingBar.completeAmount);
    }
}
