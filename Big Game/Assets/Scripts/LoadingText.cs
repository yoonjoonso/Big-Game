using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingText : MonoBehaviour
{
    public TMPro.TextMeshPro text;

    string[] loadingTexts = new string[]
    {
        "Starting Load",
        "mainmenu.scene",
        "monster.scene",
        "monster.hover",
        "monster.fbx",
        "monster.wav",
        "player.wav",
        "player.png",
        "monster.png",
        "vanilla.txt",
        "destruction.obj",
        "water.jpg",
        "twinBrothers.fbx",
        "fire.wav",
        "shoot.ogg",
        "reloading.ogg",
        "music.mod",
        "music.wav",
        "beat.wav",
        "ds.jpg",
        "loading.quiz",
        "scripts",
        "soundPlayer.player",
        "monsterHunter.player",
        "mainCamera.camera",
        "cameraman.fbx",
        "tunnelsequence.loop",
        "musicflow.fl",
        "cutscene.mp4",
        "cutscene2.mp4",
        "cutscene3.mp4",
        "cutscene4.mp4",
        "credits.mp4",
        "credits2.mp4",
        "easterEgg.mp4",
        "Compiling",
        "Finalizing assets",
        "Connecting To Server"
    };

    public void UpdateText(float progress)
    {
        string loadingText = loadingTexts[(int)(progress * loadingTexts.Length)];

        if(Mathf.Approximately(progress, .25f))
        {
            loadingText = "moveMouseAndDefend.png";
        }

        text.text = loadingText;
    }
}
